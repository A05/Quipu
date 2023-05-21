using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    public class DepositIncomePlan
    {
        public decimal TotalIncome { get; }

        public IEnumerable<(DateTime date, decimal income)> Incomes { get; }

        public DepositIncomePlan(decimal totalIncome, IEnumerable<(DateTime date, decimal income)> incomes)
        {
            TotalIncome = totalIncome;

            Incomes = incomes ?? throw new ArgumentNullException(nameof(incomes));

            Debug.Assert(TotalIncome == Incomes.Sum(i => i.income));
        }
    }
}
