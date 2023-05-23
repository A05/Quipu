namespace Sx.Vx.Quipu.Domain
{
    public interface IDepositCalculator
    {
        DepositIncomePlan Calculate(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
