using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment5
{
    public partial class OrderForm : Form
    {
        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productionInfoForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ConditionOrderformtextBox.Text = Program.productionInfoForm.PCondition;
            PlatformTextBox.Text = Program.productionInfoForm.PPlatform;
            ManufacturerTextBox.Text = Program.productionInfoForm.PManufacturer;
            ModeltextBox.Text = Program.productionInfoForm.PModel;
            ScreenSizeTextBox.Text = Program.productionInfoForm.PScreenSize;
            MemoryTextBox.Text = Program.productionInfoForm.PMemory;
            CPUBrandtextBox.Text = Program.productionInfoForm.PCPUBrand;
            CPUTypeTextBox.Text = Program.productionInfoForm.PCPUType;
            CPUNumberTextBox.Text = Program.productionInfoForm.PCPUNumber;
            CPUSpeedTextBox.Text = Program.productionInfoForm.PCPUSpeed;
            HDDtextBox.Text = Program.productionInfoForm.PHDD;
            GPUTypeTextBox.Text = Program.productionInfoForm.PGPUType;
            WebcamtextBox.Text = Program.productionInfoForm.PWebCam;
            OStextBox.Text = Program.productionInfoForm.POS;
            PriceTextBox.Text = Program.productionInfoForm.PCost; 
            double computerPrice = Convert.ToDouble(PriceTextBox.Text);
            TaxtextBox.Text = (computerPrice * 0.13).ToString();
            TotalTextBox.Text = (computerPrice * 1.13).ToString();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string message =
                "Thanks for purchasing computer today!\n\n Your order will be processed in 7-10 business days!";
            MessageBox.Show(message);
        }
    }
}
