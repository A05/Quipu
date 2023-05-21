namespace Sx.Vx.Quipu.Domain
{
    internal class DepositCalculatorFactory
    {
        public DepositCalculator Create()
        {
            var o1 = new AtTheEndOfTermDepositCalculator(null);
            var o2 = new EveryMonthDepositCalculator(o1);
            var o3 = new EveryQuarterDepositCalculator(o2);
            var o4 = new EveryYearDepositCalculator(o3);

            return o4;
        }
    }
}
