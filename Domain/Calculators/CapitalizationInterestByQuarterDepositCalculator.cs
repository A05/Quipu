using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class CapitalizationInterestByQuarterDepositCalculator : DepositCalculator
    {
        public CapitalizationInterestByQuarterDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByQuarter)
        {
        }

        protected override DepositIncomePlan CalculateImpl(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money.Amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths); // [termStart, termEnd)

            var quarter = termInMonths / 3;

            var dAmount = (double)money.Amount;
            var dInterestRate = (double)interestRate / 100d;
            var dInterestRateByQuarter = dInterestRate / 4;
            var revenue = dAmount * Math.Pow(1 + dInterestRateByQuarter, quarter);
            
            var leftDurationInMonths = termInMonths % 3;

            var dInterestRateByMonth = dInterestRate / 12;
            revenue += revenue * dInterestRateByMonth * leftDurationInMonths;

            var totalIncome = Round((decimal)revenue - money.Amount);

            return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) }.AsEnumerable());
        }
    }
}
