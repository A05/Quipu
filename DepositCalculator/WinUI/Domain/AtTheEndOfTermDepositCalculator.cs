using System;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class SimplePercentDepositCalculator : DepositCalculator
    {
        protected SimplePercentDepositCalculator(DepositCalculator next, InterestPayment interestPayment) : base(next, interestPayment)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            throw new NotImplementedException();
        }
    }

    public class AtTheEndOfTermDepositCalculator : SimplePercentDepositCalculator
    {
        public AtTheEndOfTermDepositCalculator(DepositCalculator next) : base(next, InterestPayment.AtTheEndOfTerm)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var now = DateTime.Now;
            var termEnd = now.AddMonths(termInMonths);
            var termInDays = (termEnd - now).Days;

            var totalIncome = 0m;

            var yearPeriodStart = now;
            while (termInDays > 0)
            {
                var nextYearPeriodStart = yearPeriodStart.AddYears(1);
                var yearPeriodInDays = (nextYearPeriodStart - yearPeriodStart).Days;
                var termInPeriodInDays = termInDays > yearPeriodInDays ? yearPeriodInDays : termInDays;

                var periodIncome = amount * (interestRate / 100m) * ((decimal) termInPeriodInDays / yearPeriodInDays);
                totalIncome += periodIncome;

                termInDays -= yearPeriodInDays;
                yearPeriodStart = nextYearPeriodStart;
            }

            return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) });
        }
    }

    public class EveryMonthDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryMonthDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryMonth)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var now = DateTime.Now;
            var termEnd = now.AddMonths(termInMonths);
            var termInDays = (termEnd - now).Days;

            var totalIncome = 0m;
            var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

            var periodStart = now;
            while (termInDays > 0)
            {
                var nextPeriodStart = periodStart.AddMonths(1);
                var periodInDays = (nextPeriodStart - periodStart).Days;
                var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
                var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

                var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);

                totalIncome += periodIncome;
                incomes.Add((nextPeriodStart, periodIncome));

                termInDays -= periodInDays;
                periodStart = nextPeriodStart;
            }

            return new DepositIncomePlan(totalIncome, incomes);
        }
    }

    public class EveryQuarterDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryQuarterDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryQuarter)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var now = DateTime.Now;
            var termEnd = now.AddMonths(termInMonths);
            var termInDays = (termEnd - now).Days;

            var totalIncome = 0m;
            var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

            var periodStart = now;
            while (termInDays > 0)
            {
                var nextPeriodStart = periodStart.AddMonths(3);
                var periodInDays = (nextPeriodStart - periodStart).Days;
                var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
                var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

                var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);

                totalIncome += periodIncome;
                incomes.Add((nextPeriodStart, periodIncome));

                termInDays -= periodInDays;
                periodStart = nextPeriodStart;
            }

            return new DepositIncomePlan(totalIncome, incomes);
        }
    }

    public class EveryYearDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryYearDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryYear)
        {
        }

        protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        {
            var now = DateTime.Now;
            var termEnd = now.AddMonths(termInMonths);
            var termInDays = (termEnd - now).Days;

            var totalIncome = 0m;
            var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

            var periodStart = now;
            while (termInDays > 0)
            {
                var nextPeriodStart = periodStart.AddYears(1);
                var periodInDays = (nextPeriodStart - periodStart).Days;
                var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
                var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

                var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);

                totalIncome += periodIncome;
                incomes.Add((nextPeriodStart, periodIncome));

                termInDays -= periodInDays;
                periodStart = nextPeriodStart;
            }

            return new DepositIncomePlan(totalIncome, incomes);
        }
    }
}
