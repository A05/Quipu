using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sx.Vx.Quipu.Domain
{
    public interface IDepositCalculationApplicationService
    {
        DepositIncomePlan CalculateIncomePlan(decimal amount, int termInMonths, decimal interestRate, InterestPayment interestPayment);
    }
}
