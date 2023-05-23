using System.Globalization;

namespace Sx.Vx.Quipu.WinUI
{
    internal interface ICalculatorForm
    {
        void SetViewModel(CalculatorFormViewModel viewModel);
        void ApplyResources(CultureInfo culture);
    }
}
