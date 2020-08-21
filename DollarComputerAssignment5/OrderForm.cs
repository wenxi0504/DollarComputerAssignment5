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
            // load values of objects of ProductInfo class which will display in order form
            LoadData();
        }

        public void LoadData()
        {
            ConditionOrderformtextBox.Text = ProductInfo.condition;
            PlatformTextBox.Text = ProductInfo.platform;
            ManufacturerTextBox.Text = ProductInfo.manufacturer;
            ModeltextBox.Text = ProductInfo.model;
            ScreenSizeTextBox.Text = ProductInfo.screenSize;
            MemoryTextBox.Text = ProductInfo.memory;
            CPUBrandtextBox.Text = ProductInfo.cpuBrand;
            CPUTypeTextBox.Text = ProductInfo.cpuType;
            CPUNumberTextBox.Text = ProductInfo.cpuNumber;
            CPUSpeedTextBox.Text = ProductInfo.cpuSpeed;
            HDDtextBox.Text = ProductInfo.hdd;
            GPUTypeTextBox.Text = ProductInfo.gpuType;
            WebcamtextBox.Text = ProductInfo.webcam;
            OStextBox.Text = ProductInfo.os;
            PriceTextBox.Text = ProductInfo.cost;
            double computerPrice = Convert.ToDouble(PriceTextBox.Text);
            TaxtextBox.Text = (computerPrice * 0.13).ToString();
            TotalTextBox.Text = (computerPrice * 1.13).ToString();

        }

        private void FinishButton_Click(object sender, EventArgs e)
        { // display message box 
            string message =
                "Thanks for purchasing computer today!\n\n Your order will be processed in 7-10 business days!";
            MessageBox.Show(message);
        }

       

        private void PrintOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {   // display message box 
            string printMessage = " Your selection is printing";
            MessageBox.Show(printMessage);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {  // display aboutbox message
            Program.aboutBox.Show();
        }



        
    }
}
