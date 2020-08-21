using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment5
{   //--Author's name:Wen Xu
    //--Author’s student number:301098127,
    //--Date last Modified:20,August,2020,
    //--Program description:1.0.0 version is to build multiple forms UI and project for purchasing
    //computers.
    //--Revision History:1.0.0
    static class Program
    {
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductionInfoForm productionInfoForm;
        public static OrderForm orderForm;
        public static AboutBox aboutBox;
        

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
            aboutBox=new AboutBox();
            Application.Run(new SplashForm());
        }
    }
}
