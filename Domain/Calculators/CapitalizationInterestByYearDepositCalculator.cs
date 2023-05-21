using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class CapitalizationInterestByYearDepositCalculator : DepositCalculator
    {
        public CapitalizationInterestByYearDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByYear)
        {
        }

        protected override DepositIncomePlan CalculateImpl(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money.Amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths); // [termStart, termEnd)

            var years = termInMonths / 12;

            var dAmount = (double)money.Amount;
            var dInterestRateByYear = (double)interestRate / 100d;
            var revenue = dAmount * Math.Pow(1 + dInterestRateByYear, years);

            var leftDurationInMonths = termInMonths % 12;

            var dInterestRateByMonth = dInterestRateByYear / 12;
            revenue += revenue * dInterestRateByMonth * leftDurationInMonths;

            var totalIncome = Round((decimal)revenue - money.Amount);

            return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) }.AsEnumerable());
        }
    }
}
