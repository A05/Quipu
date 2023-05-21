using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class CapitalizationInterestByDayDepositCalculator : DepositCalculator
    {
        public CapitalizationInterestByDayDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByDay)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (amount <= 0)
                throw new ArgumentException();

            var revenue = amount;

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths); // [termStart, termEnd)
            var termDurationInDays = (termEnd - termStart).Days; // [termStart, termEnd]

            var periodStart = termStart;
            var leftDurationInDays = termDurationInDays;

            while (leftDurationInDays > 0)
            {
                var periodEnd = new DateTime(periodStart.Year + 1, 01, 01); // [periodStart, periodEnd)
                var maxPeriodDurationInDays = (periodEnd - periodStart).Days; // [periodStart, periodEnd]
                var periodDuratinInDays = leftDurationInDays > maxPeriodDurationInDays ? maxPeriodDurationInDays : leftDurationInDays;

                var yearDurationInDays = DateTime.IsLeapYear(periodStart.Year) ? 366 : 365;

                var dRevenue = (double)revenue;
                var dInterestRate = (double)interestRate / 100d;
                var dInterestRateByDay = dInterestRate / yearDurationInDays;
                revenue = (decimal)(dRevenue * Math.Pow(1 + dInterestRateByDay, periodDuratinInDays));

                periodStart = periodEnd;
                leftDurationInDays -= periodDuratinInDays;
            }

            var totalIncome = Round(revenue - amount);

            return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) }.AsEnumerable());
        }
    }
}
