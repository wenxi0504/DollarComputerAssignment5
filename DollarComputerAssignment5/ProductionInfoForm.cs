using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputerAssignment5
{
    public partial class ProductionInfoForm : Form, IEnumerable
    {
        
        public ProductionInfoForm()
        {
            InitializeComponent();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // set Load data methhod to  assign values of objects of ProductInfo class
        public void LoadData()
        {
            ProductIDtextBox.Text = ProductInfo.productID;
            ConditionTextBox.Text = ProductInfo.condition;
            CosttextBox.Text = ProductInfo.cost;
            PlatformTextBox.Text = ProductInfo.platform;
            OStextBox.Text = ProductInfo.os;
            ManufacturertextBox.Text = ProductInfo.manufacturer;
            ModeltextBox.Text = ProductInfo.model;
            MemorytextBox.Text = ProductInfo.memory;
            ScreenSizetextBox.Text = ProductInfo.screenSize;
            HDDtextBox.Text = ProductInfo.hdd;
            CPUBrandtextBox.Text = ProductInfo.cpuBrand;
            CPUNumbertextBox.Text = ProductInfo.cpuNumber;
            GPUTypetextBox.Text = ProductInfo.gpuType;
            CPUTypetextBox.Text = ProductInfo.cpuType;
            CPUSpeedtextBox.Text = ProductInfo.cpuSpeed;
            WebCamtextBox.Text = ProductInfo.webcam;

        }
        public void ProductionInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
            NextButton.Enabled = true;
        }

        
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Program.orderForm.LoadData();
            this.Hide();

        }
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            ResetProductionInfoForm();
            this.Hide();

        }
        // set reset method to empty the content of textboxes
        // so that it can load new data next time
        private void ResetProductionInfoForm()
        {
            ProductIDtextBox.Text = string.Empty;
            ConditionTextBox.Text = string.Empty;
            CosttextBox.Text = string.Empty;
            PlatformTextBox.Text = string.Empty;
            OStextBox.Text = string.Empty;
            ManufacturertextBox.Text = string.Empty;
            ModeltextBox.Text = string.Empty;
            MemorytextBox.Text = string.Empty;
            ScreenSizetextBox.Text = string.Empty;
            HDDtextBox.Text = string.Empty;
            CPUBrandtextBox.Text = string.Empty;
            CPUNumbertextBox.Text = string.Empty;
            GPUTypetextBox.Text = string.Empty;
            CPUTypetextBox.Text = string.Empty;
            CPUSpeedtextBox.Text = string.Empty;
            WebCamtextBox.Text = string.Empty;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the save file dialog
            ProductionInfosaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            // display the savefiledialog and save the results in the saveFileDialogResult object
            var saveFileDialogResult = ProductionInfosaveFileDialog.ShowDialog();

            if (saveFileDialogResult != DialogResult.Cancel)
            {
                // create new stream
                StreamWriter streamWriter = new StreamWriter(ProductionInfosaveFileDialog.FileName);

                // write to the file
                streamWriter.WriteLine(ProductInfo.productID);
                streamWriter.WriteLine(ProductInfo.condition);
                streamWriter.WriteLine(ProductInfo.cost);
                streamWriter.WriteLine(ProductInfo.platform);
                streamWriter.WriteLine(ProductInfo.os);
                streamWriter.WriteLine(ProductInfo.manufacturer);
                streamWriter.WriteLine(ProductInfo.model);
                streamWriter.WriteLine(ProductInfo.memory);
                streamWriter.WriteLine(ProductInfo.screenSize);
                streamWriter.WriteLine(ProductInfo.hdd);
                streamWriter.WriteLine(ProductInfo.cpuBrand);
                streamWriter.WriteLine(ProductInfo.cpuNumber);
                streamWriter.WriteLine(ProductInfo.gpuType);
                streamWriter.WriteLine(ProductInfo.cpuType);
                streamWriter.WriteLine(ProductInfo.cpuSpeed);
                streamWriter.WriteLine(ProductInfo.webcam);
                
                // clean up
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the open file dialog
            ProductInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            // open the file dialog
            var openFileDialogResult = ProductInfoOpenFileDialog.ShowDialog();

            if (openFileDialogResult != DialogResult.Cancel)
            {
                // create a new stream reader
                StreamReader streamReader = new StreamReader(ProductInfoOpenFileDialog.FileName);
            
                // read the file

                while (!streamReader.EndOfStream)
                {
                    ProductInfo.productID = streamReader.ReadLine();
                    ProductInfo.condition = streamReader.ReadLine();
                    ProductInfo.cost = streamReader.ReadLine();
                    ProductInfo.platform = streamReader.ReadLine();
                    ProductInfo.os = streamReader.ReadLine();
                    ProductInfo.manufacturer = streamReader.ReadLine();
                    ProductInfo.model = streamReader.ReadLine();
                    ProductInfo.memory = streamReader.ReadLine();
                    ProductInfo.screenSize = streamReader.ReadLine();
                    ProductInfo.hdd = streamReader.ReadLine();
                    ProductInfo.cpuBrand = streamReader.ReadLine();
                    ProductInfo.cpuNumber = streamReader.ReadLine();
                    ProductInfo.gpuType = streamReader.ReadLine();
                    ProductInfo.cpuType = streamReader.ReadLine();
                    ProductInfo.cpuSpeed = streamReader.ReadLine();
                    ProductInfo.webcam = streamReader.ReadLine();
                }

                // cleanup
                streamReader.Close();
            }
            LoadData();



        }
    }
}
