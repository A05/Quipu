using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sx.Vx.Quipu.Domain
{
    internal static class DepositCalculatorFactory
    {
        public static DepositCalculator Create()
        {
            var r1 = new AtTheEndOfTermDepositCalculator(null);
            //var r2 = new TeamXTotalsMarketRules(probabilitiesBuilder, r1);
            //var r3 = new TeamXFirstMOversTotalMarketRules(probabilitiesBuilder, r2);
            //var r4 = new InningsNOverMTeamXTotalMarketRules(probabilitiesBuilder, r3);

            return r1;
        }
    }
}
