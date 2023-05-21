using System;
using System.Linq;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.Domain
{
    public abstract class SimplePercentDepositCalculator : DepositCalculator
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

            var termStart = DateTime.Now;
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

    public class AtTheEndOfTermInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public AtTheEndOfTermInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.AtTheEndOfTerm)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths)
        {
            return termInMonths;
        }

        //protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        //{
        //    var now = DateTime.Now;
        //    var termEnd = now.AddMonths(termInMonths);
        //    var termInDays = (termEnd - now).Days;

        //    var totalIncome = 0m;

        //    var yearPeriodStart = now;
        //    while (termInDays > 0)
        //    {
        //        var nextYearPeriodStart = yearPeriodStart.AddYears(1);
        //        var yearPeriodInDays = (nextYearPeriodStart - yearPeriodStart).Days;
        //        var termInPeriodInDays = termInDays > yearPeriodInDays ? yearPeriodInDays : termInDays;

        //        var periodIncome = amount * (interestRate / 100m) * ((decimal) termInPeriodInDays / yearPeriodInDays);
        //        periodIncome = Round(periodIncome);
        //        totalIncome += periodIncome;

        //        termInDays -= yearPeriodInDays;
        //        yearPeriodStart = nextYearPeriodStart;
        //    }

        //    return new DepositIncomePlan(totalIncome, new[] { (termEnd, totalIncome) });
        //}
    }

    public class EveryMonthInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryMonthInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryMonth)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths)
        {
            return 1;
        }

        //protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        //{
        //    var now = DateTime.Now;
        //    var termEnd = now.AddMonths(termInMonths);
        //    var termInDays = (termEnd - now).Days;

        //    var totalIncome = 0m;
        //    var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

        //    var periodStart = now;
        //    while (termInDays > 0)
        //    {
        //        var nextPeriodStart = periodStart.AddMonths(1);
        //        var periodInDays = (nextPeriodStart - periodStart).Days;
        //        var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
        //        var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

        //        var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);
        //        periodIncome = Round(periodIncome);

        //        totalIncome += periodIncome;
        //        incomes.Add((nextPeriodStart, periodIncome));

        //        termInDays -= periodInDays;
        //        periodStart = nextPeriodStart;
        //    }

        //    return new DepositIncomePlan(totalIncome, incomes);
        //}
    }

    public class EveryQuarterInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryQuarterInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryQuarter)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths)
        {
            return 3;
        }

        //protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        //{
        //    var now = DateTime.Now;
        //    var termEnd = now.AddMonths(termInMonths);
        //    var termInDays = (termEnd - now).Days;

        //    var totalIncome = 0m;
        //    var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

        //    var periodStart = now;
        //    while (termInDays > 0)
        //    {
        //        var nextPeriodStart = periodStart.AddMonths(3);
        //        var periodInDays = (nextPeriodStart - periodStart).Days;
        //        var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
        //        var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

        //        var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);
        //        periodIncome = Round(periodIncome);

        //        totalIncome += periodIncome;
        //        incomes.Add((nextPeriodStart, periodIncome));

        //        termInDays -= periodInDays;
        //        periodStart = nextPeriodStart;
        //    }

        //    return new DepositIncomePlan(totalIncome, incomes);
        //}
    }

    public class EveryYearInterestDepositCalculator : SimplePercentDepositCalculator
    {
        public EveryYearInterestDepositCalculator(DepositCalculator next) : base(next, InterestPayment.EveryYear)
        {
        }

        protected override int GetIncomeIntervalInMonths(int termInMonths)
        {
            return 12;
        }

        //protected override DepositIncomePlan CalculateImpl(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment)
        //{
        //    var now = DateTime.Now;
        //    var termEnd = now.AddMonths(termInMonths);
        //    var termInDays = (termEnd - now).Days;

        //    var totalIncome = 0m;
        //    var incomes = new List<(DateTime date, decimal income)>(capacity: termInMonths);

        //    var periodStart = now;
        //    while (termInDays > 0)
        //    {
        //        var nextPeriodStart = periodStart.AddYears(1);
        //        var periodInDays = (nextPeriodStart - periodStart).Days;
        //        var termInPeriodInDays = termInDays > periodInDays ? periodInDays : termInDays;
        //        var periodYearInDays = (new DateTime(periodStart.Year + 1, 1, 1) - new DateTime(periodStart.Year, 1, 1)).TotalDays;

        //        var periodIncome = amount * (interestRate / 100m) * (termInPeriodInDays / (decimal)periodYearInDays);
        //        periodIncome = Round(periodIncome);

        //        totalIncome += periodIncome;
        //        incomes.Add((nextPeriodStart, periodIncome));

        //        termInDays -= periodInDays;
        //        periodStart = nextPeriodStart;
        //    }

        //    return new DepositIncomePlan(totalIncome, incomes);
        //}
    }
}
