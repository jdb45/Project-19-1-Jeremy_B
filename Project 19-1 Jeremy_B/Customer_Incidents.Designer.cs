namespace Project_19_1_Jeremy_B
{
    partial class Customer_Incidents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Incidents));
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupport_DataDataSet = new Project_19_1_Jeremy_B.TechSupport_DataDataSet();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddEditCustomer = new System.Windows.Forms.Button();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtCustomerIdSearch = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.findByStateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.CustomersTableAdapter();
            this.incidentsTableAdapter = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.fillByCustomerIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(23, 98);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(103, 20);
            customerIDLabel.TabIndex = 21;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 138);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(23, 178);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(23, 218);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(119, 20);
            cityLabel.TabIndex = 27;
            cityLabel.Text = "City, State, ZIP:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(23, 255);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 31;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 295);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 33;
            emailLabel.Text = "Email:";
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.AllowUserToAddRows = false;
            this.incidentsDataGridView.AllowUserToDeleteRows = false;
            this.incidentsDataGridView.AutoGenerateColumns = false;
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.incidentsDataGridView.DataSource = this.incidentsBindingSource;
            this.incidentsDataGridView.Location = new System.Drawing.Point(12, 375);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.RowTemplate.Height = 28;
            this.incidentsDataGridView.Size = new System.Drawing.Size(991, 237);
            this.incidentsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IncidentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "IncidentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOpened";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateOpened";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 133;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateClosed";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateClosed";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 133;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(27, 641);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 35);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddEditCustomer
            // 
            this.btnAddEditCustomer.Location = new System.Drawing.Point(784, 209);
            this.btnAddEditCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEditCustomer.Name = "btnAddEditCustomer";
            this.btnAddEditCustomer.Size = new System.Drawing.Size(202, 35);
            this.btnAddEditCustomer.TabIndex = 36;
            this.btnAddEditCustomer.Text = "Add/Edit Customers";
            this.btnAddEditCustomer.UseVisualStyleBackColor = true;
            this.btnAddEditCustomer.Click += new System.EventHandler(this.btnAddEditCustomer_Click);
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(784, 631);
            this.btnAddIncident.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(202, 35);
            this.btnAddIncident.TabIndex = 35;
            this.btnAddIncident.Text = "&Add New Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(152, 93);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(148, 26);
            this.txtCustomerID.TabIndex = 22;
            this.txtCustomerID.TabStop = false;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(152, 133);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(348, 26);
            this.txtName.TabIndex = 24;
            this.txtName.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(152, 173);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(348, 26);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(152, 213);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(148, 26);
            this.txtCity.TabIndex = 28;
            this.txtCity.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State", true));
            this.txtState.Location = new System.Drawing.Point(311, 213);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(40, 26);
            this.txtState.TabIndex = 29;
            this.txtState.TabStop = false;
            // 
            // txtZipCode
            // 
            this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZipCode", true));
            this.txtZipCode.Location = new System.Drawing.Point(362, 213);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(138, 26);
            this.txtZipCode.TabIndex = 30;
            this.txtZipCode.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(152, 250);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(148, 26);
            this.txtPhone.TabIndex = 32;
            this.txtPhone.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(152, 290);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(348, 26);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.TabStop = false;
            // 
            // fillByCustomerIDToolStrip
            // 
            this.fillByCustomerIDToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByCustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.txtCustomerIdSearch,
            this.fillByCustomerIDToolStripButton,
            this.findByStateToolStripButton});
            this.fillByCustomerIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByCustomerIDToolStrip.Name = "fillByCustomerIDToolStrip";
            this.fillByCustomerIDToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(1023, 32);
            this.fillByCustomerIDToolStrip.TabIndex = 38;
            this.fillByCustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(111, 29);
            this.customerIDToolStripLabel.Text = "CustomerID:";
            // 
            // txtCustomerIdSearch
            // 
            this.txtCustomerIdSearch.Name = "txtCustomerIdSearch";
            this.txtCustomerIdSearch.Size = new System.Drawing.Size(148, 32);
            // 
            // fillByCustomerIDToolStripButton
            // 
            this.fillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustomerIDToolStripButton.Name = "fillByCustomerIDToolStripButton";
            this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(50, 29);
            this.fillByCustomerIDToolStripButton.Text = "Find";
            this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // findByStateToolStripButton
            // 
            this.findByStateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findByStateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("findByStateToolStripButton.Image")));
            this.findByStateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findByStateToolStripButton.Name = "findByStateToolStripButton";
            this.findByStateToolStripButton.Size = new System.Drawing.Size(118, 29);
            this.findByStateToolStripButton.Text = "Find By State";
            this.findByStateToolStripButton.Click += new System.EventHandler(this.findByStateToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Project 19-1 Jeremy_B";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.IncidentsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegistrationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // Customer_Incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1023, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByCustomerIDToolStrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddEditCustomer);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.incidentsDataGridView);
            this.Name = "Customer_Incidents";
            this.Text = "Customer Incidents";
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.fillByCustomerIDToolStrip.ResumeLayout(false);
            this.fillByCustomerIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupport_DataDataSet techSupport_DataDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupport_DataDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupport_DataDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddEditCustomer;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolStrip fillByCustomerIDToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox txtCustomerIdSearch;
        private System.Windows.Forms.ToolStripButton fillByCustomerIDToolStripButton;
        private System.Windows.Forms.ToolStripButton findByStateToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

