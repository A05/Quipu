using Sx.Vx.Quipu.Domain;

namespace Sx.Vx.Quipu.WinUI
{
    internal interface ILimitRepository
    {
        Limit Get(Currency currency);
    }
}
