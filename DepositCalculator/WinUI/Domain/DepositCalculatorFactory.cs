namespace Sx.Vx.Quipu.Domain
{
    internal class DepositCalculatorFactory
    {
        public DepositCalculator Create()
        {
            var r1 = new AtTheEndOfTermDepositCalculator(null);
            //var r2 = new TeamXTotalsMarketRules(probabilitiesBuilder, r1);
            //var r3 = new TeamXFirstMOversTotalMarketRules(probabilitiesBuilder, r2);
            //var r4 = new InningsNOverMTeamXTotalMarketRules(probabilitiesBuilder, r3);

            return r1;
        }
    }
}
