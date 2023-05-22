using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    public class DepositIncomePlan
    {
        public Money TotalIncome { get; }

        public IEnumerable<(DateTime date, Money income)> Incomes { get; }

        internal DepositIncomePlan(Money totalIncome, IEnumerable<(DateTime date, Money income)> incomes)
        {
            TotalIncome = totalIncome;

            Incomes = incomes ?? throw new ArgumentNullException(nameof(incomes));

            Debug.Assert(TotalIncome == Incomes.Sum(i => i.income));
        }

        public override string ToString()
        {
            return $"{TotalIncome}, Incomes Count = {Incomes.Count()}";
        }
    }
}
