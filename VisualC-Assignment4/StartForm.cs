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
