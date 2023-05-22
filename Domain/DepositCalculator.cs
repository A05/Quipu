using System;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class DepositCalculator
    {
        private readonly DepositCalculator _next;
        private readonly InterestPayment _interestPayment;
        
        protected DepositCalculator(DepositCalculator next, InterestPayment interestPayment)
        {
            _next = next;
            
            if ((_interestPayment = interestPayment) == InterestPayment.Unknown)
                throw new ArgumentException("Interest payment must be specified.", nameof(interestPayment));
        }

        public DepositIncomePlan Calculate(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money <= 0)
                throw new ArgumentException("Amount must be greater than zero.", nameof(money));

            if (termInMonths <= 0)
                throw new ArgumentException("Term must be greater than zero.", nameof(termInMonths));

            if (interestRate <= 0)
                throw new ArgumentException("Interest rate must be greater than zero.", nameof(interestRate));

            if (interestPayment == InterestPayment.Unknown)
                throw new ArgumentException("Interest payment be specified.", nameof(interestPayment));

            if (_interestPayment == interestPayment)
                return CalculateImpl(money, termInMonths, interestRate, interestPayment);

            if (_next != null)
                return _next.Calculate(money, termInMonths, interestRate, interestPayment);

            throw new NotSupportedException($"The {interestPayment:G} interest payment is not supported yet.");
        }

        protected abstract DepositIncomePlan CalculateImpl(Money amount, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
