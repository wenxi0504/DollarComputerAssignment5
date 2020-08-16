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

        public List<ProductionInfoForm> ProductionInfo{ get; set; }
        public ProductionInfoForm()
        {
            InitializeComponent();
        }

        public string PProductID
        {
            get { return ProductIDtextBox.Text; }
            set { }
        }
        public string PCondition
        {
            get { return ConditionTextBox.Text; }
            set { }
        }
        public string PCost
        {
            get { return CosttextBox.Text; }
            set { }
        }
        public string PPlatform
        {
            get { return PlatformTextBox.Text; }
            set { }
        }
        public string POS
        {
            get {return OStextBox.Text; }
            set { }
        }
        public string PManufacturer
        {
            get { return ManufacturertextBox.Text; }
            set { }
        }
        public string PModel
        {
            get { return ModeltextBox.Text; }
            set { }
        }
        public string PMemory
        {
            get { return MemorytextBox.Text; }
            set { }
        }
        public string PScreenSize
        {
            get { return ScreenSizetextBox.Text; }
            set { }
        }
        public string PHDD
        {
            get { return HDDtextBox.Text; }
            set { }
        }
        public string PCPUBrand
        {
            get { return CPUBrandtextBox.Text; }
            set { }
        }
        public string PCPUNumber
        {
            get { return CPUNumbertextBox.Text; }
            set { }
        }
        public string PGPUType
        {
            get { return GPUTypetextBox.Text; }
            set { }
        }
        public string PCPUType
        {
            get { return CPUTypetextBox.Text; }
            set { }
        }
        public string PCPUSpeed
        {
            get { return CPUSpeedtextBox.Text; }
            set { }
        }
        public string PWebCam
        {
            get { return WebCamtextBox.Text; }
            set { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ProductionInfoForm_Load(object sender, EventArgs e)
        {
            CosttextBox.Text = Program.selectForm.cost;
            ProductIDtextBox.Text = Program.selectForm.productID;
            ConditionTextBox.Text = Program.selectForm.condition;
            PlatformTextBox.Text = Program.selectForm.platform;
            OStextBox.Text = Program.selectForm.os;
            ManufacturertextBox.Text = Program.selectForm.manufacturer;
            ModeltextBox.Text = Program.selectForm.model;
            MemorytextBox.Text = Program.selectForm.memory;
            ScreenSizetextBox.Text = Program.selectForm.screenSize;
            HDDtextBox.Text = Program.selectForm.hdd;
            CPUBrandtextBox.Text = Program.selectForm.cpuBrand;
            CPUNumbertextBox.Text = Program.selectForm.cpuNumber;
            GPUTypetextBox.Text = Program.selectForm.gpuType;
            CPUTypetextBox.Text = Program.selectForm.cpuType;
            CPUSpeedtextBox.Text = Program.selectForm.cpuSpeed;
            WebCamtextBox.Text = Program.selectForm.webcam;
            NextButton.Enabled = true;

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();

        }
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
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
                streamWriter.WriteLine(Program.productionInfoForm.PProductID);
                streamWriter.WriteLine(Program.productionInfoForm.PCondition);
                streamWriter.WriteLine(Program.productionInfoForm.PCost);
                streamWriter.WriteLine(Program.productionInfoForm.PPlatform);
                streamWriter.WriteLine(Program.productionInfoForm.POS);
                streamWriter.WriteLine(Program.productionInfoForm.PManufacturer);
                streamWriter.WriteLine(Program.productionInfoForm.PModel);
                streamWriter.WriteLine(Program.productionInfoForm.PMemory);
                streamWriter.WriteLine(Program.productionInfoForm.PScreenSize);
                streamWriter.WriteLine(Program.productionInfoForm.PHDD);
                streamWriter.WriteLine(Program.productionInfoForm.PCPUBrand);
                streamWriter.WriteLine(Program.productionInfoForm.PCPUNumber);
                streamWriter.WriteLine(Program.productionInfoForm.PGPUType);
                streamWriter.WriteLine(Program.productionInfoForm.PCPUType);
                streamWriter.WriteLine(Program.productionInfoForm.PCPUSpeed);
                streamWriter.WriteLine(Program.productionInfoForm.PWebCam);
                
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
                ProductionInfo = new List<ProductionInfoForm>();
                // read in the list

                while (!streamReader.EndOfStream)
                {
                    streamReader.ReadLine();
                    //ContactListBox.Items.Add(streamReader.ReadLine());
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                }



                // cleanup
                streamReader.Close();
            }




        }
    }
}
