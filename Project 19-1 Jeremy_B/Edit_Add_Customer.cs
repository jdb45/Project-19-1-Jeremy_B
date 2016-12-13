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
    public partial class Edit_Add_Customer : Form
    {
        public Edit_Add_Customer()
        {
            InitializeComponent();
        }


        private void Edit_Add_Customer_Load(object sender, EventArgs e)
        {
           try { 
                //loading the customer table
            this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                try
                {
                    this.Validate();
                    //ending the edit to the database
                    this.customersBindingSource.EndEdit();
                    //updating the database
                    this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);
                } //catching the concurrent update exception
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " +
                        "Some rows were not updated.", "Concurrency Exception");
                    this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);
                }
                //catching the general ADO.NET error
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    customersBindingSource.CancelEdit();
                }
                //catching the database SQL exception
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }
            }

        //method to open the form
        public void openEditCustomer()
        {
            this.ShowDialog();
        }
        //method to close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //method to seach by customer ID
        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                //converting the search ID text to an int
                int customerID = Convert.ToInt32(txtCustomerIdSearch.Text);
                //filling the table by the searched customer ID
                this.customersTableAdapter.FillByCustomerID(this.techSupport_DataDataSet.Customers, customerID);
                //checking if the search result is 0, and if so give an error
                if (customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No customers with that ID found.",
                        "ID not found");
                    txtCustomerIdSearch.Focus();
                }
            }
            catch (SqlException sqle)
            {
                string msg = "Database error # " + sqle.Number + ":\n" + sqle.Message;
                string caption = sqle.GetType().ToString();
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to search by state
        private void findByStateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //filling by state based on what the user entered
                this.customersTableAdapter.FillByState(this.techSupport_DataDataSet.Customers, txtCustomerIdSearch.Text);
                //checking if the search result is 0, and if so give an error
                if (customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No customers found in " + txtCustomerIdSearch,
                        "No Customers Found");
                    txtCustomerIdSearch.Focus();
                }

            }
            //catching exceptions 
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to restore all the fields
        private void restoreAllToolStripButton_Click(object sender, EventArgs e)
        {
            //switching the search box to and empty string
            txtCustomerIdSearch.Text = "";
            try
            {
                //returning all the results of the table back 
                this.customersTableAdapter.Fill(this.techSupport_DataDataSet.Customers);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
