using System;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class SimplePercentDepositCalculator : DepositCalculator
    {
        protected SimplePercentDepositCalculator(DepositCalculator next, InterestPayment interestPayment) : base(next, interestPayment)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            throw new NotImplementedException();
        }
    }

    public class AtTheEndOfTermDepositCalculator : SimplePercentDepositCalculator
    {
        public AtTheEndOfTermDepositCalculator(DepositCalculator next) : base(next, InterestPayment.AtTheEndOfTerm)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var now = DateTime.Now;
            var termEnd = now.AddMonths(termInMonths);
            var termInDays = (termEnd - now).Days;

            var totalIncome = 0m;

            var yearPeriodStart = now;
            while (termInDays > 0)
            {
                var nextYearPeriodStart = yearPeriodStart.AddYears(1);
                var yearPeriodInDays = (nextYearPeriodStart - yearPeriodStart).Days;
                var termInPeriodInDays = termInDays > yearPeriodInDays ? yearPeriodInDays : termInDays;

                var periodIncome = amount * (interestRate / 100) * (yearPeriodInDays / termInPeriodInDays);
                totalIncome += periodIncome;

                termInDays -= yearPeriodInDays;
                yearPeriodStart = nextYearPeriodStart;
            }

            return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) });
        }
    }
}
