using System;
using System.Linq;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    internal abstract class SimplePercentDepositCalculator : DepositCalculator
    {
        protected SimplePercentDepositCalculator(DepositCalculator next, InterestPayment interestPayment) : base(next, interestPayment)
        {
        }

        protected sealed override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (amount <= 0)
                throw new ArgumentException();

            var totalIncome = 0m;
            var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

            var termStart = DateTime.Now; // TODO: (UUUU) plus one problem!!!
            var termEnd = termStart.AddMonths(termInMonths);
            var termDurationInDays = (termEnd - termStart).Days;

            var totalOfIncomeInterval = 0m;
            var incomeIntervalInMonths = GetIncomeIntervalInMonths(termInMonths);

            var periodStart = termStart;
            var leftDurationInDays = termDurationInDays;

            for (int months = 1; leftDurationInDays > 0; months++)
            {
                var periodEnd = periodStart.AddMonths(1);
                var maxPeriodDurationInDays = (periodEnd - periodStart).Days;
                var periodDurationInDays = leftDurationInDays > maxPeriodDurationInDays ? maxPeriodDurationInDays : leftDurationInDays;

                var yearDurationInDays = DateTime.IsLeapYear(periodStart.Year) ? 366 : 365;

                var periodIncome = amount * (interestRate / 100m) * (periodDurationInDays / (decimal)yearDurationInDays);
                periodIncome = Round(periodIncome);

                leftDurationInDays -= maxPeriodDurationInDays;
                periodStart = periodEnd;

                totalIncome += periodIncome;
                totalOfIncomeInterval += periodIncome;

                if (months % incomeIntervalInMonths == 0 || leftDurationInDays <= 0)
                {
                    incomes.Add((periodEnd, totalOfIncomeInterval));
                    totalOfIncomeInterval = 0m;
                }
            }

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }

        protected abstract int GetIncomeIntervalInMonths(int termInMonths);
    }
}
