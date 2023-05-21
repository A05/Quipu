namespace Sx.Vx.Quipu.Domain
{
    public class DepositCalculatorFactory
    {
        public DepositCalculator Create()
        {
            var o1 = new AtTheEndOfTermInterestDepositCalculator(null);
            var o2 = new EveryMonthInterestDepositCalculator(o1);
            var o3 = new EveryQuarterInterestDepositCalculator(o2);
            var o4 = new EveryYearInterestDepositCalculator(o3);

            return o4;
        }
    }
}
