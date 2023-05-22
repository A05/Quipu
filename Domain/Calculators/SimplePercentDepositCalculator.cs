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

        protected sealed override DepositIncomePlan CalculateImpl(Money money, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            if (money <= 0)
                throw new ArgumentException();

            var totalIncome = money.New(0);
            var incomes = new List<(DateTime date, Money income)>(capacity: termInMonths);

            var termStart = DateTime.Now;
            var termEnd = termStart.AddMonths(termInMonths);
            var termDurationInDays = (termEnd - termStart).Days;

            var totalOfIncomeInterval = money.New(0);
            var incomeIntervalInMonths = GetIncomeIntervalInMonths(termInMonths);

            var periodStart = termStart;
            var leftDurationInDays = termDurationInDays;

            for (int months = 1; leftDurationInDays > 0; months++)
            {
                var periodEnd = periodStart.AddMonths(1);
                var maxPeriodDurationInDays = (periodEnd - periodStart).Days;
                var periodDurationInDays = leftDurationInDays > maxPeriodDurationInDays ? maxPeriodDurationInDays : leftDurationInDays;

                var yearDurationInDays = DateTime.IsLeapYear(periodStart.Year) ? 366 : 365;

                var periodIncomeAmount = money * (interestRate / 100m) * (periodDurationInDays / (decimal)yearDurationInDays);
                var periodIncome = money.New(periodIncomeAmount).Rounded;

                leftDurationInDays -= maxPeriodDurationInDays;
                periodStart = periodEnd;

                totalIncome += periodIncome;
                totalOfIncomeInterval += periodIncome;

                if (months % incomeIntervalInMonths == 0 || leftDurationInDays <= 0)
                {
                    incomes.Add((periodEnd, totalOfIncomeInterval));
                    totalOfIncomeInterval = money.New(0);
                }
            }

            return new DepositIncomePlan(totalIncome, incomes.AsEnumerable());
        }

        protected abstract int GetIncomeIntervalInMonths(int termInMonths);
    }
}
