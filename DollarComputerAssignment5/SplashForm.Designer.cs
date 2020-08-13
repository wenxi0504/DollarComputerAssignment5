namespace DollarComputerAssignment5
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.WelcomeSplashFormlabel = new System.Windows.Forms.Label();
            this.WelcomeSpalshFormpictureBox = new System.Windows.Forms.PictureBox();
            this.Splashtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeSpalshFormpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeSplashFormlabel
            // 
            this.WelcomeSplashFormlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeSplashFormlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.WelcomeSplashFormlabel.Location = new System.Drawing.Point(-2, 81);
            this.WelcomeSplashFormlabel.Name = "WelcomeSplashFormlabel";
            this.WelcomeSplashFormlabel.Size = new System.Drawing.Size(641, 146);
            this.WelcomeSplashFormlabel.TabIndex = 0;
            this.WelcomeSplashFormlabel.Text = "Welcome to Dollar Computer";
            this.WelcomeSplashFormlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeSpalshFormpictureBox
            // 
            this.WelcomeSpalshFormpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WelcomeSpalshFormpictureBox.Image")));
            this.WelcomeSpalshFormpictureBox.Location = new System.Drawing.Point(236, 206);
            this.WelcomeSpalshFormpictureBox.Name = "WelcomeSpalshFormpictureBox";
            this.WelcomeSpalshFormpictureBox.Size = new System.Drawing.Size(192, 125);
            this.WelcomeSpalshFormpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WelcomeSpalshFormpictureBox.TabIndex = 1;
            this.WelcomeSpalshFormpictureBox.TabStop = false;
            // 
            // Splashtimer
            // 
            this.Splashtimer.Enabled = true;
            this.Splashtimer.Interval = 5000;
            this.Splashtimer.Tick += new System.EventHandler(this.Splashtimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeSpalshFormpictureBox);
            this.Controls.Add(this.WelcomeSplashFormlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.WelcomeSpalshFormpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeSplashFormlabel;
        private System.Windows.Forms.PictureBox WelcomeSpalshFormpictureBox;
        private System.Windows.Forms.Timer Splashtimer;
    }
}

