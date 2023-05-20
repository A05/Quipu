namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal class EveryYearInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryYearInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryYear)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths) => 12;
    }
}
