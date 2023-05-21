namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class EveryMonthInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryMonthInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryMonth)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths) => 1;
    }
}
