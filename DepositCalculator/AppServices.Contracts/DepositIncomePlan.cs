using System;

namespace Sx.Vx.Quipu.DepositCalculator.WinUIAppServices
{
    [Serializable]
    public class DepositIncomePlan
    {
        public decimal Income { get; private set; }

        public DepositIncomePlan(decimal income)
        {
            Income = income;
        }
    }
}
