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
            var manufacturer = ComputerHardwareDataGridView.SelectedRows[0].Cells[1].Value;
            var model= ComputerHardwareDataGridView.SelectedRows[0].Cells[2].Value;
            var cost =ComputerHardwareDataGridView.SelectedRows[0].Cells[3].Value;
            SelectionOutputTextBox.Text = $" {manufacturer} {model} {cost} ";
            NextSelectButton.Enabled = true;
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
