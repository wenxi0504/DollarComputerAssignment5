using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment5
{
    static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductionInfoForm productionInfoForm;
        public static OrderForm orderForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm = new StartForm();
            selectForm = new SelectForm();
            productionInfoForm = new ProductionInfoForm();
            orderForm = new OrderForm();

            Application.Run(new SplashForm());
        }
    }
}
