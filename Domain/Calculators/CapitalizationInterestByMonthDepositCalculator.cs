using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class CapitalizationInterestByMonthDepositCalculator : DepositCalculator
    {
        public CapitalizationInterestByMonthDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByMonth)
        {
        }

        protected override DepositIncomePlan CalculateImpl(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money.Amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths);

            var dAmount = (double)money.Amount;
            var dInterestRate = (double)interestRate / 100d;
            var dInterestRateByMonth = dInterestRate / 12;
            var revenue = (decimal)(dAmount * Math.Pow(1 + dInterestRateByMonth, termInMonths));

            var totalIncome = Round(revenue - money.Amount);
            var incomes = new[] { (termEnd, totalIncome) };

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }
    }
}
