using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class CapitalizationInterestByMonthDepositCalculator : DepositCalculator
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
    }
}
