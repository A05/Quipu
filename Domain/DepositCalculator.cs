using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class DepositCalculator
    {
        private readonly DepositCalculator _next;
        private readonly InterestPayment[] _interestPayments;
        
        protected DepositCalculator(DepositCalculator next, params InterestPayment[] interestPayments)
        {
            _next = next;
            _interestPayments = interestPayments ?? throw new ArgumentException("Interest payment is not specified.");
        }

        public DepositIncomePlan Calculate(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (_interestPayments.Contains(interestPayment))
                return CalculateImpl(money, termInMonths, interestRate, interestPayment);

            if (_next != null)
                return _next.Calculate(money, termInMonths, interestRate, interestPayment);

            throw new NotSupportedException($"The {interestPayment:G} interest payment is not supported yet.");
        }

        protected abstract DepositIncomePlan CalculateImpl(Money amount, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
