namespace Sx.Vx.Quipu.Domain
{
    public class DepositIncomePlan
    {
        public decimal Income { get; private set; }

        public DepositIncomePlan(decimal income)
        {
            Income = income;
        }
    }
}
