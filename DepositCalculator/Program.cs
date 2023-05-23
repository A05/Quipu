using Sx.Vx.Quipu.Domain;
using Sx.Vx.Quipu.WinUI.Properties;
using System;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CalculatorForm mainForm = null;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                mainForm = Bootstrap();

                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    mainForm, 
                    string.Format(Resources.UnhandledErrorMessage, ex), 
                    Resources.UnhandledErrorCaption, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        static CalculatorForm Bootstrap()
        {
            // TODO: Implement it with Unity.

            var limitRepository = LimitRepository.Load(fallbackOnError: true);
            var viewModelFactory = new CalculatorFormViewModelFactory(limitRepository);
            var calculatorFactory = new DepositCalculatorFactory();
            var presenter = new CalculatorFormPresenter(viewModelFactory, calculatorFactory);

            var mainForm = new CalculatorForm(presenter);

            return mainForm;
        }
    }
}
