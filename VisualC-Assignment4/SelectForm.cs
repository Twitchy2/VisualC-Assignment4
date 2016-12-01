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
            foreach (DataGridViewColumn column in DatabaseDataGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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
            try
            {
                ComputerInfo CompInfo = Program.CompInfo;
                DatabaseDataGrid.Rows[e.RowIndex].Selected = true;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DatabaseDataGrid.Rows[e.RowIndex];
                    SelectedTextBox.Text = row.Cells[2].Value.ToString() + ", " + row.Cells[3].Value.ToString() + ", " + row.Cells[1].Value.ToString(); //Tried to put "C" in here but apperently it doesnt liek that
                                                                                                                                                        //I hate this and I bet there was an easier way

                    Program.CompInfo.ProductID = row.Cells[0].Value.ToString();

                    Program.CompInfo.Cost = row.Cells[1].Value.ToString();

                    Program.CompInfo.Manufactuer = row.Cells[2].Value.ToString();
                    Program.CompInfo.Model = row.Cells[3].Value.ToString();

                    Program.CompInfo.Ram_type = row.Cells[4].Value.ToString();
                    Program.CompInfo.Ram_size = row.Cells[5].Value.ToString();
                    Program.CompInfo.DisplayType = row.Cells[6].Value.ToString();

                    Program.CompInfo.Screensize = row.Cells[7].Value.ToString();
                    Program.CompInfo.Resolution = row.Cells[8].Value.ToString();
                    Program.CompInfo.CPU_class = row.Cells[9].Value.ToString();
                    Program.CompInfo.CPU_brand = row.Cells[10].Value.ToString();
                    Program.CompInfo.CPU_type = row.Cells[11].Value.ToString();
                    Program.CompInfo.CPU_speed = row.Cells[12].Value.ToString();
                    Program.CompInfo.CPU_number = row.Cells[13].Value.ToString();

                    Program.CompInfo.conidtion = row.Cells[14].Value.ToString();
                    Program.CompInfo.OS = row.Cells[15].Value.ToString();
                    Program.CompInfo.Platform = row.Cells[16].Value.ToString();
                    Program.CompInfo.HDD_Size = row.Cells[17].Value.ToString();
                    Program.CompInfo.HDD_Speed = row.Cells[18].Value.ToString();

                    Program.CompInfo.GPU_type = row.Cells[19].Value.ToString();
                    Program.CompInfo.Optical_drive = row.Cells[20].Value.ToString();
                    Program.CompInfo.Audio_type = row.Cells[21].Value.ToString();
                    Program.CompInfo.LAN = row.Cells[22].Value.ToString();
                    Program.CompInfo.WIFI = row.Cells[23].Value.ToString();
                    Program.CompInfo.width = row.Cells[24].Value.ToString();

                    Program.CompInfo.height = row.Cells[25].Value.ToString();
                    Program.CompInfo.depth = row.Cells[26].Value.ToString();
                    Program.CompInfo.weight = row.Cells[27].Value.ToString();
                    Program.CompInfo.mouse_type = row.Cells[28].Value.ToString();
                    Program.CompInfo.power = row.Cells[29].Value.ToString();
                    Program.CompInfo.webcame = row.Cells[30].Value.ToString();


                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Please remember not to select the column headers!", "It breaks the program");
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
