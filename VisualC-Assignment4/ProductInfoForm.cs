using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualC_Assignment4
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private static void Quit()
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open a file and put it in the product form
            //create instance of openfiledialog
            OpenFileDialog openFIleDialog = new OpenFileDialog();
            //set properties
            openFIleDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFIleDialog.Title = "Open File";
            openFIleDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            //Open the DIalog Box
            DialogResult = openFIleDialog.ShowDialog();

            if (DialogResult != DialogResult.Cancel)
            {
                StreamReader read = new StreamReader(openFIleDialog.FileName);
                ProductInfoForm info = new ProductInfoForm();
                //This block of code will put stuff in place

                info.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You did not choose a file!", "Returning to the last form!");
            }
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.CompInfo.ProductID;
            ConditionTextBox.Text = Program.CompInfo.conidtion;
            CostTextBox.Text = Program.CompInfo.Cost;

            PlatformTextBox.Text = Program.CompInfo.Platform;
            ManuTextBox.Text = Program.CompInfo.Manufactuer;
            OSTextBox.Text = Program.CompInfo.OS;
            ModelTextBox.Text = Program.CompInfo.Model;

            MemoryTextBox.Text = Program.CompInfo.Ram_size;
            SpeedTextBox.Text = Program.CompInfo.CPU_speed;
            BrandTextBox.Text = Program.CompInfo.CPU_brand;
            TypeTextBox.Text = Program.CompInfo.CPU_type;

            LCDTextBox.Text = Program.CompInfo.Screensize;
            CPUTextBox.Text = Program.CompInfo.CPU_number;

            HDDTextBox.Text = Program.CompInfo.HDD_Size;
            GPUTextBox.Text = Program.CompInfo.GPU_type;
            WebCamTextBox.Text = Program.CompInfo.webcame;


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }
        /// <summary>
        /// Save the product info
        /// </summary>
        private void SaveProduct()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save?", "Save Names", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //Open stream
                StreamWriter writer = new StreamWriter("ProductInfo.txt", true);
                //write to stream
                //do you hate us by giving us so much to put on there?
                writer.WriteLine(ProductIDTextBox.Text +  ", " + ConditionTextBox.Text + ", " + CostTextBox.Text + ", " +
                                PlatformTextBox.Text + ", " + OSTextBox.Text + ", " + ManuTextBox.Text + ", " + ModelTextBox.Text + ", " +
                                MemoryTextBox.Text + ", " + BrandTextBox.Text + ", " + TypeTextBox.Text + ", " +
                                LCDTextBox.Text + ", " + CPUTextBox.Text + ", " + SpeedTextBox.Text + ", " +
                                HDDTextBox.Text + ", " + GPUTextBox.Text + ", " + WebCamTextBox. Text);
                //Close 
                writer.Close();
            }

            else
            {
                NextButton.Focus();
            }
        }
    }
}
