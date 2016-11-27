using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualC_Assignment4.Properties;

namespace VisualC_Assignment4
{
    public partial class OrderForm : Form
    {
        public double price;
        public double salesTax = 0.13;
        public double FinalPrice;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Back()
        {
            ProductInfoForm product = new ProductInfoForm();
            product.Show();
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            
            PriceTextBox.Text = Program.CompInfo.Cost;
            price = Convert.ToDouble(PriceTextBox.Text);

            TaxTextBox.Text = (price * salesTax).ToString();

            FinalPrice = price + Convert.ToDouble(TaxTextBox.Text);

            FinalTextBox.Text = FinalPrice.ToString();

            PlatformTextBox.Text = Program.CompInfo.Platform;
            ManuTextBox.Text = Program.CompInfo.Manufactuer;
            OSTextBox.Text = Program.CompInfo.OS;
            ModelTextBox.Text = Program.CompInfo.Model;
            NumberTextBox.Text = Program.CompInfo.CPU_number;

            MemoryTextBox.Text = Program.CompInfo.Ram_size;
            SpeedTextBox.Text = Program.CompInfo.CPU_speed;
            BrandTextBox.Text = Program.CompInfo.CPU_brand;
            TypeTextBox.Text = Program.CompInfo.CPU_type;

            LCDTextBox.Text = Program.CompInfo.Screensize;
            SpeedTextBox.Text = Program.CompInfo.CPU_number;

            HDDTextBox.Text = Program.CompInfo.HDD_Size;
            GPUTextBox.Text = Program.CompInfo.GPU_type;
            WebcamTextBox.Text = Program.CompInfo.webcame;
            OsTextBox2.Text = Program.CompInfo.OS;
            //now for the piture box
            //Finds the name of hte string and compares it to hte name of the image, sets if same
            String imageString = Regex.Replace(ManuTextBox.Text, @"\+", "");

            SharpPictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);

        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for ordering, printing now", "Thanks for the money, too");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank you for your order,\n your product should arrive within 7-10 buisness Days.\n We hope you order again!", "Order Complete", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }


}
