using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_1_Jeremy_B
{
    public partial class Find_Customers : Form
    {
        public Find_Customers()
        {
            InitializeComponent();
        }
        public static int customerSelectedText;

        private void Find_Customers_Load(object sender, EventArgs e)
        {
            try
            {
                //loading the fille by state in the customer table adapter
                this.customersTableAdapter.FillByState(this.techSupport_DataDataSet.Customers, Customer_Incidents.stateSearchText);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }


        }
        //method to load the find customer form
        public void show_Customer()
        {
            this.ShowDialog();
        }


        private void btnOK_Click(object sender, EventArgs e)

        {
            //checking each row of the selected row to get the customer ID number
            foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
            {
                String holdIDNumber = row.Cells[0].Value.ToString();
                //converting the value to bring to the next form
                customerSelectedText = Convert.ToInt32(holdIDNumber);
            }
            
            this.Dispose();
        }
        //method to close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByStateToolStripButton_Click(object sender, EventArgs e)
        {
            
            try
            {   //filling by state based on what the user entered
                this.customersTableAdapter.FillByState(this.techSupport_DataDataSet.Customers, txtstateToolStrip.Text);
                //checking if the search result is 0, and if so give an error
                if (customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No customers found in " + txtstateToolStrip,
                        "No Customers Found");
                    txtstateToolStrip.Focus();
                }
               
            }//catching excepions
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //a double click method to bring the selected customer over to the next form
        private void customersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //checking each row of the selected row to get the customer ID number
            foreach (DataGridViewRow row in customersDataGridView.SelectedRows)
            {
                String hold = row.Cells[0].Value.ToString();
                //converting the value to bring to the next form
                customerSelectedText = Convert.ToInt32(hold);
            }

            this.Dispose();
        }
    }
}
