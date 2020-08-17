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
    public partial class SelectForm : Form
    {
        public string productID { get; set; }
        public string condition { get; set; }
        public string cost { get; set; }
        public string platform { get; set; }
        public string os { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string memory { get; set; }
        public string screenSize { get; set; }
        public string hdd { get; set; }
        public string cpuBrand { get; set; }
        public string cpuNumber { get; set; }
        public string gpuType { get; set; }
        public string cpuType { get; set; }
        public string cpuSpeed { get; set; }

        public string webcam { get; set; }
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void ComputerHardwareDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Program.selectForm.cost= ComputerHardwareDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Program.selectForm.manufacturer = ComputerHardwareDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.selectForm.model = ComputerHardwareDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SelectionOutputTextBox.Text = $" {manufacturer} {model} {cost} ";
            NextSelectButton.Enabled = true;
            Program.selectForm.productID = ComputerHardwareDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Program.selectForm.condition = ComputerHardwareDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.selectForm.platform = ComputerHardwareDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.selectForm.os = ComputerHardwareDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.selectForm.memory = ComputerHardwareDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.selectForm.screenSize = ComputerHardwareDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.selectForm.hdd = ComputerHardwareDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.selectForm.cpuBrand = ComputerHardwareDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.selectForm.cpuSpeed = ComputerHardwareDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.selectForm.cpuType = ComputerHardwareDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.selectForm.cpuNumber = ComputerHardwareDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.selectForm.webcam = ComputerHardwareDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            Program.selectForm.gpuType = ComputerHardwareDataGridView.SelectedRows[0].Cells[19].Value.ToString();
        }

        private void CancelSelectButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextSelectButton_Click(object sender, EventArgs e)
        {
            Program.productionInfoForm.Show();
            this.Hide();
           

        }
      
    }
}
