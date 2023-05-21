using Sx.Vx.Quipu.Domain.Calculators;

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
            var o5 = new CapitalizationInterestByDayDepositCalculator(o4);
            var o6 = new CapitalizationInterestByMonthDepositCalculator(o5);
            var o7 = new CapitalizationInterestByQuarterDepositCalculator(o6);
            var o8 = new CapitalizationInterestByQuarterDepositCalculator(o7);

            return o8;
        }
    }
}
