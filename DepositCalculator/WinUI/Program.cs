using Sx.Vx.Quipu.DepositCalculator.WinUIAppServices;
using System;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.DepositCalculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationService = new DepositCalculationApplicationService();
            var presenter = new CalculatorFormPresenter(applicationService);

            Application.Run(new CalculatorForm(presenter));
        }
    }
}
