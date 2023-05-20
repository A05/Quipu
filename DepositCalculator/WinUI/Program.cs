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

            var calculator = DepositCalculatorFactory.Create();
            var presenter = new CalculatorFormPresenter(calculator);

            Application.Run(new CalculatorForm(presenter));
        }
    }
}
