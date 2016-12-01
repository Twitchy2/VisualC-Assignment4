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
        /// <summary>
        /// Reads the file given and prints into the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                
                //use readline
                string CompInfoRead = read.ReadLine();
                //split from the commoas
                string[] linestring = CompInfoRead.Split(',');
                //here come that linegrab
                Program.CompInfo.ProductID = linestring[0];
                Program.CompInfo.conidtion = linestring[1];
                Program.CompInfo.Cost = linestring[2];
                Program.CompInfo.Platform = linestring[3];
                Program.CompInfo.OS = linestring[4];
                Program.CompInfo.Manufactuer = linestring[5];
                Program.CompInfo.Model = linestring[6];
                Program.CompInfo.Ram_size = linestring[7];
                Program.CompInfo.CPU_brand = linestring[8];
                Program.CompInfo.CPU_type = linestring[9];
                Program.CompInfo.Screensize = linestring[10];
                Program.CompInfo.CPU_number = linestring[11];
                Program.CompInfo.CPU_speed = linestring[12];
                Program.CompInfo.HDD_Size = linestring[13];
                Program.CompInfo.GPU_type = linestring[14];
                Program.CompInfo.webcame = linestring[15];

                //re print it all
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
            //open a file and put it in the product form
            //create instance of openfiledialog
            SaveFileDialog Save = new SaveFileDialog();
            //set properties
            Save.InitialDirectory = Directory.GetCurrentDirectory();
            Save.Title = "Save File";
            Save.FileName = "Products.txt";
            Save.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            //Open the DIalog Box
            if (Save.ShowDialog() == DialogResult.OK)
            {
                //Open stream
                StreamWriter writer = new StreamWriter(Save.OpenFile());
                //write to stream
                //do you hate us by giving us so much to put on there?
                writer.WriteLine(ProductIDTextBox.Text +  "," + ConditionTextBox.Text + "," + CostTextBox.Text + "," +
                                PlatformTextBox.Text + "," + OSTextBox.Text + "," + ManuTextBox.Text + "," + ModelTextBox.Text + "," +
                                MemoryTextBox.Text + "," + BrandTextBox.Text + "," + TypeTextBox.Text + "," +
                                LCDTextBox.Text + "," + CPUTextBox.Text + "," + SpeedTextBox.Text + "," +
                                HDDTextBox.Text + "," + GPUTextBox.Text + "," + WebCamTextBox.Text);
                //Close 
                writer.Close();
            }

            else
            {
                NextButton.Focus();
            }
        }
        /// <summary>
        /// we gotta go back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectLabel_Click(object sender, EventArgs e)
        {
            //not actually a label
            //will close this down and open the old one up
            GoBack();
        }
        /// <summary>
        /// guess what this does
        /// </summary>
        private void GoBack()
        {
            SelectForm formSelect = new SelectForm();
            formSelect.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
            this.Hide();
            
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoBack();
        }
    }
}
