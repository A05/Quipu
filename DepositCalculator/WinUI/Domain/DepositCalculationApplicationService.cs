using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sx.Vx.Quipu.Domain
{
    public class DepositCalculationApplicationService
    {
        public DepositIncomePlan CalculateIncomePlan(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var rnd = new Random((int) DateTime.Now.Ticks);
            return new DepositIncomePlan((decimal) (rnd.NextDouble() * 20000d));
        }
    }
}
