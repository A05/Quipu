using Sx.Vx.Quipu.Domain.Properties;
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
                throw new ArgumentException(ErrorMessages.InterestPaymentMustBeSpecified, nameof(interestPayment));
        }

        public DepositIncomePlan Calculate(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money <= 0)
                throw new ArgumentException(ErrorMessages.AmountMustBeGreaterThanZero, nameof(money));

            if (termInMonths <= 0)
                throw new ArgumentException(ErrorMessages.TermMustBeGreaterThanZero, nameof(termInMonths));

            if (interestRate <= 0)
                throw new ArgumentException(ErrorMessages.InterestRateMustBeGreaterThanZero, nameof(interestRate));

            if (interestPayment == InterestPayment.Unknown)
                throw new ArgumentException(ErrorMessages.InterestPaymentMustBeSpecified, nameof(interestPayment));

            if (_interestPayment == interestPayment)
                return CalculateImpl(money, termInMonths, interestRate, interestPayment);

            if (_next != null)
                return _next.Calculate(money, termInMonths, interestRate, interestPayment);

            throw new NotSupportedException(string.Format(ErrorMessages.InterestPaymentIsNotSupportedYet, interestPayment));
        }

        protected abstract DepositIncomePlan CalculateImpl(Money amount, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
