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
    public partial class Customer_Incidents : Form
    {
        public Customer_Incidents()
        {
            InitializeComponent();
        }

        public static String stateSearchText;

        //method to close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void findByStateToolStripButton_Click(object sender, EventArgs e)
        {
            //creating a variable of the Find_Customers form
            Find_Customers findCustomers = new Find_Customers();
            //getting the information in the text box
            stateSearchText = txtCustomerIdSearch.Text;
            txtCustomerIdSearch.Text = "";
            //opening the Find_Customers form
            findCustomers.show_Customer();

            try
            {
                //Filling the customer table adapter
                this.customersTableAdapter.FillByCustomerID(this.techSupport_DataDataSet.Customers, Find_Customers.customerSelectedText);
                //Filling the incidents table adapter
                this.incidentsTableAdapter.FillByCustomerID(this.techSupport_DataDataSet.Incidents, Find_Customers.customerSelectedText);


            } //catching exceptions 
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                    //filling the table by the searched customer ID
                    this.incidentsTableAdapter.FillByCustomerID(this.techSupport_DataDataSet.Incidents, customerID);
                    //checking if the search result is 0, and if so give an error
                    if (customersBindingSource.Count == 0)
                    {
                        MessageBox.Show("No customers with that ID found.",
                            "ID not found");
                        txtCustomerIdSearch.Focus();
                    }
                } //catching exceptions
                catch (SqlException ex)
                {
                     MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }
        //method for adding a incident
        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            //if no customer is selected, make the user select one
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please select a customer.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerIdSearch.Focus();
            }
            //if a customer is selcted
            else
            {
                //creating an add incident variable and opening up the form
                Add_Incident addIncident = new Add_Incident();
                addIncident.setTxtBoxes(txtCustomerID.Text, txtName.Text);
                //filling the form by the selected customer ID
                this.incidentsTableAdapter.FillByCustomerID(this.techSupport_DataDataSet.Incidents, Convert.ToInt32(txtCustomerID.Text));
            }
        }

        //method to add and edit customers
        private void btnAddEditCustomer_Click(object sender, EventArgs e)
        {
            Edit_Add_Customer editCustomer = new Edit_Add_Customer();
            editCustomer.openEditCustomer();
        }
    }
}
