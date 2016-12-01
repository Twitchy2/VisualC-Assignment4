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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// opens up a file and brings you to prodiuct info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedButton_Click(object sender, EventArgs e)
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
                info.Show();
                this.Hide();
                

       
            } else
            {
                MessageBox.Show("You did not choose a file!", "Returning to StartForm");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
