namespace Sx.Vx.Quipu.Domain
{
    internal class DepositCalculatorFactory
    {
        public DepositCalculator Create()
        {
            var r1 = new AtTheEndOfTermDepositCalculator(null);
            var r2 = new EveryMonthDepositCalculator(r1);
            var r3 = new EveryQuarterDepositCalculator(r2);
            //var r4 = new InningsNOverMTeamXTotalMarketRules(probabilitiesBuilder, r3);

            return r3;
        }
    }
}
