using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_19_1_Jeremy_B
{
    public partial class Add_Incident : Form
    {
        public Add_Incident()
        {
            InitializeComponent();
        }

        private void Add_Incident_Load(object sender, EventArgs e)
        {
            try
            {
                //loading the customer with the selcted product code
                this.productsTableAdapter.FillByProductCode(this.techSupport_DataDataSet.Products, Convert.ToInt32(txtCustomerID.Text));
            }//catching the SQL exception
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }
        }
        //a method to set the customer ID and customer name from the Customer incidents form
        public void setTxtBoxes(string customerID, string customerName)
        {
            this.txtCustomerID.Text = customerID;
            this.txtCustomerName.Text = customerName;
            this.ShowDialog();
        }
        //method to close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            //checking to make sure the data that is entered is correct
            if (IsValidData())
            {
                //insertting a new row into the database
                TechSupport_DataDataSet.IncidentsRow newInsertedRow;
                newInsertedRow = techSupport_DataDataSet.Incidents.NewIncidentsRow();
                //getting the value from the customer ID
                newInsertedRow.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //getting the value from the product code
                newInsertedRow.ProductCode = cmboProductCode.SelectedValue.ToString();
                //getting the value from the title of the incident
                newInsertedRow.Title = txtTitle.Text;
                //geting the value of the description
                newInsertedRow.Description = txtDescription.Text;
                //getting the date and time set to now
                newInsertedRow.DateOpened = DateTime.Now;
                //adding the information to the new row
                this.techSupport_DataDataSet.Incidents.Rows.Add(newInsertedRow);
                //saving the row
                this.incidentsTableAdapter.Update(this.techSupport_DataDataSet.Incidents);
                this.Close();
            }
        }

        //creating a method to return if the validation is true or false 
        public bool IsValidData()
        {
            return
                Validator.IsPresent(txtTitle, "Title")&&
                Validator.IsPresent(txtDescription, "Discription");
                

        }
    }
}
