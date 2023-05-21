using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class DepositCalculator
    {
        // TODO: (U) make money class
        public static decimal Round(decimal value)
        {
            return Math.Truncate(value * 100) / 100; 
        }

        private readonly DepositCalculator _next;
        private readonly InterestPayment[] _interestPayments;
        
        protected DepositCalculator(DepositCalculator next, params InterestPayment[] interestPayments)
        {
            _next = next;
            _interestPayments = interestPayments ?? throw new ArgumentException("Interest payment is not specified.");
        }

        public DepositIncomePlan Calculate(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (_interestPayments.Contains(interestPayment))
                return CalculateImpl(amount, termInMonths, interestRate, interestPayment);

            if (_next != null)
                return _next.Calculate(amount, termInMonths, interestRate, interestPayment);

            throw new NotSupportedException($"The {interestPayment:G} interest payment is not supported yet.");
        }

        protected abstract DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
