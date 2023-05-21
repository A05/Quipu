using System;
using System.Linq;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal abstract class ComplexPercentDepositCalculator : DepositCalculator
    {
        protected ComplexPercentDepositCalculator(DepositCalculator next, InterestPayment interestPayment) : base(next, interestPayment)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths);

            var capitalizationUnitCountPerYear = GetCapitalizationUnitCountPerYear();
            var capitalizationUnitCount = GetCapitalizationUnitCount(termInMonths);

            var dAmount = (double)amount;
            var dInterestRate = (double)interestRate / 100d;
            var dInterestRateByCapitalizationUnit = dInterestRate / capitalizationUnitCountPerYear;
            var mainIncome = (decimal)(dAmount * Math.Pow(1 + dInterestRateByCapitalizationUnit, capitalizationUnitCount));

            var remainderIncome = CalculateRemainder();

            var totalIncome = mainIncome + remainderIncome;
            var incomes = new[] { (termEnd, totalIncome) };

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }

        protected abstract int GetCapitalizationUnitCountPerYear();

        protected abstract int GetCapitalizationUnitCount(int termInMonths);

        protected virtual decimal CalculateRemainder() => decimal.Zero;
    }

    /// <summary>
    /// 
    /// </summary>
    internal class CapitalizationInterestByDayDepositCalculator : ComplexPercentDepositCalculator
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

        protected override int GetCapitalizationUnitCountPerYear() => 365; // TODO: (NU) A leap year phenomenon should be taken into considiration.

        protected override int GetCapitalizationUnitCount(int termInMonths) => termInMonths * 1;
    }

    /// <summary>
    /// 
    /// </summary>
    internal class CapitalizationInterestByMonthDepositCalculator : ComplexPercentDepositCalculator
    {
        public CapitalizationInterestByMonthDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByMonth)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths);

            var dAmount = (double)amount;
            var dInterestRate = (double)interestRate / 100d;
            var dInterestRateByMonth = dInterestRate / 12;
            var revenue = (decimal)(dAmount * Math.Pow(1 + dInterestRateByMonth, termInMonths));

            var totalIncome = Round(revenue - amount);
            var incomes = new[] { (termEnd, totalIncome) };

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }

        protected override int GetCapitalizationUnitCountPerYear() => 12;

        protected override int GetCapitalizationUnitCount(int termInMonths) => termInMonths;
    }
}
