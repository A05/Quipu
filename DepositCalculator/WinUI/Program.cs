using Sx.Vx.Quipu.DepositCalculator.WinUIAppServices;
using System;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationService = new DepositCalculationApplicationService();
            var presenter = new MainFormPresenter(applicationService);

            Application.Run(new MainForm(presenter));
        }
    }
}
