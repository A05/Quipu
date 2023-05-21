using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sx.Vx.Quipu.Domain
{
    public struct Money
    {
        public decimal Amount { get; }

        public Currency Currency { get; }
    }
}
