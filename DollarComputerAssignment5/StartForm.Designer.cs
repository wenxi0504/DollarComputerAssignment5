namespace DollarComputerAssignment5
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.OrderComputerTodaylabel = new System.Windows.Forms.Label();
            this.StartPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.StartButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartPhotoPictureBox)).BeginInit();
            this.StartButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderComputerTodaylabel
            // 
            this.OrderComputerTodaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComputerTodaylabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrderComputerTodaylabel.Location = new System.Drawing.Point(2, 9);
            this.OrderComputerTodaylabel.Name = "OrderComputerTodaylabel";
            this.OrderComputerTodaylabel.Size = new System.Drawing.Size(614, 48);
            this.OrderComputerTodaylabel.TabIndex = 0;
            this.OrderComputerTodaylabel.Text = "Order Your Computer Today!";
            this.OrderComputerTodaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartPhotoPictureBox
            // 
            this.StartPhotoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StartPhotoPictureBox.Image")));
            this.StartPhotoPictureBox.Location = new System.Drawing.Point(190, 71);
            this.StartPhotoPictureBox.Name = "StartPhotoPictureBox";
            this.StartPhotoPictureBox.Size = new System.Drawing.Size(193, 143);
            this.StartPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StartPhotoPictureBox.TabIndex = 1;
            this.StartPhotoPictureBox.TabStop = false;
            // 
            // StartButtonsGroupBox
            // 
            this.StartButtonsGroupBox.Controls.Add(this.ExitButton);
            this.StartButtonsGroupBox.Controls.Add(this.SavedOrderButton);
            this.StartButtonsGroupBox.Controls.Add(this.NewOrderButton);
            this.StartButtonsGroupBox.Location = new System.Drawing.Point(190, 245);
            this.StartButtonsGroupBox.Name = "StartButtonsGroupBox";
            this.StartButtonsGroupBox.Size = new System.Drawing.Size(193, 167);
            this.StartButtonsGroupBox.TabIndex = 2;
            this.StartButtonsGroupBox.TabStop = false;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(4, 4);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(186, 50);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "NewOrder";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedOrderButton.Location = new System.Drawing.Point(3, 58);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(186, 50);
            this.SavedOrderButton.TabIndex = 1;
            this.SavedOrderButton.Text = "SavedOrder";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            this.SavedOrderButton.Click += new System.EventHandler(this.SavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(3, 111);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(186, 50);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.StartButtonsGroupBox);
            this.Controls.Add(this.StartPhotoPictureBox);
            this.Controls.Add(this.OrderComputerTodaylabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartPhotoPictureBox)).EndInit();
            this.StartButtonsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrderComputerTodaylabel;
        private System.Windows.Forms.PictureBox StartPhotoPictureBox;
        private System.Windows.Forms.GroupBox StartButtonsGroupBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Button NewOrderButton;
    }
}