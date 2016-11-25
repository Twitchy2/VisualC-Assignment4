using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualC_Assignment4
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment4DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.assignment4DataSet.products);

        }
        /// <summary>
        /// Should take whatever is clicked and put the Product ID into the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectDatabaseInfo(e);
        }
        /// <summary>
        /// Well the above isnt true becuase this method does everything the click says
        /// </summary>
        /// <param name="e"></param>
        private void SelectDatabaseInfo(DataGridViewCellEventArgs e)
        {
            DatabaseDataGrid.Rows[e.RowIndex].Selected = true;
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.DatabaseDataGrid.Rows[e.RowIndex];
                SelectedTextBox.Text = row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + ", " + row.Cells[1].Value.ToString(); //Tried to put "C" in here but apperently it doesnt liek that
            }
            NextButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// see u last form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm infoForm = new ProductInfoForm();

            infoForm.Show();

            this.Hide();
        }
    }
}
