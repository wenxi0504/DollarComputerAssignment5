﻿using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {  //display select form
            Program.selectForm.Show();
            this.Hide();
        }

        private void SavedOrderButton_Click(object sender, EventArgs e)
        {   // display productionInfo form
            Program.productionInfoForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {  // exit the application
            Application.Exit();
        }
    }
}
