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
            //PlatformTextBox.Text=
            //    ManufacturerTextBox.Text=
            //        ModeltextBox.Text=
            //            ScreenSizeTextBox.Text=
            //                MemoryTextBox.Text=
            //                    CPUBrandtextBox.Text=
            //                        CPUTypeTextBox.Text=
            //                            CPUNumberTextBox.Text=
            //                                CPUSpeedTextBox.Text=
            //                                    HDDtextBox.Text=
            //                                        GPUTypeTextBox.Text= 
            //                                            WebcamtextBox.Text=
            //OStextBox.Text=





        }

        private void ConditionOrderformtextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
