using Sx.Vx.Quipu.Domain;
using System;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = Bootstrap();

            Application.Run(mainForm);
        }

        static CalculatorForm Bootstrap()
        {
            // TODO: Implement it with Unity.

            var viewModelFactory = new CalculatorFormViewModelFactory();
            var calculatorFactory = new DepositCalculatorFactory();
            var presenter = new CalculatorFormPresenter(viewModelFactory, calculatorFactory);

            var mainForm = new CalculatorForm(presenter);

            return mainForm;
        }
    }
}
