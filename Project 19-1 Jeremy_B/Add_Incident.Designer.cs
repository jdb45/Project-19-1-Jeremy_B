namespace Project_19_1_Jeremy_B
{
    partial class Add_Incident
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboProductCode = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.ProductsTableAdapter();
            this.incidentsTableAdapter = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter();
            this.tableAdapterManager = new Project_19_1_Jeremy_B.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            this.techSupport_DataDataSet = new Project_19_1_Jeremy_B.TechSupport_DataDataSet();
            customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(135, 27);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(148, 26);
            this.txtCustomerID.TabIndex = 14;
            this.txtCustomerID.TabStop = false;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(23, 32);
            customerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(103, 20);
            customerIDLabel.TabIndex = 13;
            customerIDLabel.Text = "Customer ID:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(271, 375);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(393, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product:";
            // 
            // cmboProductCode
            // 
            this.cmboProductCode.DataSource = this.productsBindingSource;
            this.cmboProductCode.DisplayMember = "Name";
            this.cmboProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboProductCode.FormattingEnabled = true;
            this.cmboProductCode.Location = new System.Drawing.Point(135, 155);
            this.cmboProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboProductCode.Name = "cmboProductCode";
            this.cmboProductCode.Size = new System.Drawing.Size(272, 28);
            this.cmboProductCode.TabIndex = 18;
            this.cmboProductCode.ValueMember = "ProductCode";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 243);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(363, 99);
            this.txtDescription.TabIndex = 22;
            this.txtDescription.Tag = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(135, 202);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(363, 26);
            this.txtTitle.TabIndex = 20;
            this.txtTitle.Tag = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Title:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(135, 72);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(272, 26);
            this.txtCustomerName.TabIndex = 16;
            this.txtCustomerName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
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
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
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
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 443);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmboProductCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Name = "Add_Incident";
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.Add_Incident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboProductCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupport_DataDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TechSupport_DataDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TechSupport_DataDataSet techSupport_DataDataSet;
    }
}