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
            // Assign database data to productinfo objects
            ProductInfo.cost = ComputerHardwareDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProductInfo.manufacturer = ComputerHardwareDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProductInfo.model = ComputerHardwareDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SelectionOutputTextBox.Text = $" {ProductInfo.manufacturer} {ProductInfo.model} {ProductInfo.cost} ";
            NextSelectButton.Enabled = true;
            ProductInfo.productID = ComputerHardwareDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProductInfo.condition = ComputerHardwareDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            ProductInfo.platform = ComputerHardwareDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            ProductInfo.os = ComputerHardwareDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            ProductInfo.memory = ComputerHardwareDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            ProductInfo.screenSize = ComputerHardwareDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            ProductInfo.hdd = ComputerHardwareDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            ProductInfo.cpuBrand = ComputerHardwareDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            ProductInfo.cpuSpeed = ComputerHardwareDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            ProductInfo.cpuType = ComputerHardwareDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            ProductInfo.cpuNumber = ComputerHardwareDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            ProductInfo.webcam = ComputerHardwareDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            ProductInfo.gpuType = ComputerHardwareDataGridView.SelectedRows[0].Cells[19].Value.ToString();
        }

        private void CancelSelectButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextSelectButton_Click(object sender, EventArgs e)
        {
            Program.productionInfoForm.Show();
            this.Hide();
            Program.productionInfoForm.ProductionInfoForm_Load(sender, e);



        }
      
    }
}
