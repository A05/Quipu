namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class EveryQuarterInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryQuarterInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryQuarter)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths) => 3;
    }
}
