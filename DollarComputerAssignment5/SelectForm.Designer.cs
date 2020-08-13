namespace DollarComputerAssignment5
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComputerSelectionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YourSelectionlabel = new System.Windows.Forms.Label();
            this.SelectionOutputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputerSelectionLabel
            // 
            this.ComputerSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerSelectionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ComputerSelectionLabel.Location = new System.Drawing.Point(13, 13);
            this.ComputerSelectionLabel.Name = "ComputerSelectionLabel";
            this.ComputerSelectionLabel.Size = new System.Drawing.Size(432, 55);
            this.ComputerSelectionLabel.TabIndex = 0;
            this.ComputerSelectionLabel.Text = "Dollar Computer Hardwear List";
            this.ComputerSelectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectionOutputTextBox);
            this.groupBox1.Controls.Add(this.YourSelectionlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // YourSelectionlabel
            // 
            this.YourSelectionlabel.AutoSize = true;
            this.YourSelectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.YourSelectionlabel.Location = new System.Drawing.Point(6, 22);
            this.YourSelectionlabel.Name = "YourSelectionlabel";
            this.YourSelectionlabel.Size = new System.Drawing.Size(127, 20);
            this.YourSelectionlabel.TabIndex = 0;
            this.YourSelectionlabel.Text = "Your Selection";
            // 
            // SelectionOutputTextBox
            // 
            this.SelectionOutputTextBox.Location = new System.Drawing.Point(140, 21);
            this.SelectionOutputTextBox.Name = "SelectionOutputTextBox";
            this.SelectionOutputTextBox.ReadOnly = true;
            this.SelectionOutputTextBox.Size = new System.Drawing.Size(358, 26);
            this.SelectionOutputTextBox.TabIndex = 1;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComputerSelectionLabel);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ComputerSelectionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label YourSelectionlabel;
        private System.Windows.Forms.TextBox SelectionOutputTextBox;
    }
}