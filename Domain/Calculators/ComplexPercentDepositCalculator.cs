using System;
using System.Linq;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal abstract class ComplexPercentDepositCalculator : DepositCalculator
    {
        protected ComplexPercentDepositCalculator(DepositCalculator next, InterestPayment interestPayment) : base(next, interestPayment)
        {
        }

        protected sealed override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (amount <= 0)
                throw new ArgumentException();

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths);

            var capitalizationUnitCountPerYear = GetCapitalizationUnitCountPerYear();
            var capitalizationUnitCount = GetCapitalizationUnitCount(termInMonths);

            var dAmount = (double)amount;
            var dInterestRate = (double)interestRate / 100d;
            var dInterestRateByCapitalizationUnit = dInterestRate / capitalizationUnitCountPerYear;
            var mainIncome = (decimal)(dAmount * Math.Pow(1 + dInterestRateByCapitalizationUnit, capitalizationUnitCount));

            var remainderIncome = CalculateRemainder();

            var totalIncome = mainIncome + remainderIncome;
            var incomes = new[] { (termEnd, totalIncome) };

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }

        protected abstract int GetCapitalizationUnitCountPerYear();

        protected abstract int GetCapitalizationUnitCount(int termInMonths);

        protected virtual decimal CalculateRemainder() => decimal.Zero;
    }

    internal class CapitalizationInterestByDayDepositCalculator : ComplexPercentDepositCalculator
    {
        public CapitalizationInterestByDayDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByDay)
        {
        }

        protected override int GetCapitalizationUnitCountPerYear() => 12;

        protected override int GetCapitalizationUnitCount(int termInMonths) => termInMonths;
    }

    internal class CapitalizationInterestByMonthDepositCalculator : ComplexPercentDepositCalculator
    {
        public CapitalizationInterestByMonthDepositCalculator(DepositCalculator next) : base(next, InterestPayment.CapitalizationByMonth)
        {
        }

        protected override int GetCapitalizationUnitCountPerYear() => 12;

        protected override int GetCapitalizationUnitCount(int termInMonths) => termInMonths;
    }
}
