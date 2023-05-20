namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class AtTheEndOfTermInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public AtTheEndOfTermInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.AtTheEndOfTerm)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths) => termInMonths;
    }
}
