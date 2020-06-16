namespace software_database
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loantypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientcommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofdependentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverslicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residencestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofkinphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextofkinemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentemployerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentemployerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faclientprofilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataApplication = new software_database.DataApplication();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.textClientComments = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textSuburb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.texthomeaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCreditRating = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApplicationType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLoanType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLoanStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.fa_client_profilesTableAdapter = new software_database.DataApplicationTableAdapters.fa_client_profilesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faclientprofilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplication)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loanstatusDataGridViewTextBoxColumn,
            this.loantypeDataGridViewTextBoxColumn,
            this.applicationtypeDataGridViewTextBoxColumn,
            this.creditratingDataGridViewTextBoxColumn,
            this.loanamountDataGridViewTextBoxColumn,
            this.clientcommentsDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.maritalstatusDataGridViewTextBoxColumn,
            this.numofdependentsDataGridViewTextBoxColumn,
            this.driverslicenseDataGridViewTextBoxColumn,
            this.residencestatusDataGridViewTextBoxColumn,
            this.homeaddressDataGridViewTextBoxColumn,
            this.suburbDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.homephoneDataGridViewTextBoxColumn,
            this.mobphoneDataGridViewTextBoxColumn,
            this.nextofkinDataGridViewTextBoxColumn,
            this.nextofkinphoneDataGridViewTextBoxColumn,
            this.nextofkinemailDataGridViewTextBoxColumn,
            this.employmentstatusDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn,
            this.currentemployerDataGridViewTextBoxColumn,
            this.currentemployerphoneDataGridViewTextBoxColumn,
            this.lenderDataGridViewTextBoxColumn,
            this.contractnumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.faclientprofilesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(865, 571);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanstatusDataGridViewTextBoxColumn
            // 
            this.loanstatusDataGridViewTextBoxColumn.DataPropertyName = "loanstatus";
            this.loanstatusDataGridViewTextBoxColumn.HeaderText = "loanstatus";
            this.loanstatusDataGridViewTextBoxColumn.Name = "loanstatusDataGridViewTextBoxColumn";
            // 
            // loantypeDataGridViewTextBoxColumn
            // 
            this.loantypeDataGridViewTextBoxColumn.DataPropertyName = "loantype";
            this.loantypeDataGridViewTextBoxColumn.HeaderText = "loantype";
            this.loantypeDataGridViewTextBoxColumn.Name = "loantypeDataGridViewTextBoxColumn";
            // 
            // applicationtypeDataGridViewTextBoxColumn
            // 
            this.applicationtypeDataGridViewTextBoxColumn.DataPropertyName = "applicationtype";
            this.applicationtypeDataGridViewTextBoxColumn.HeaderText = "applicationtype";
            this.applicationtypeDataGridViewTextBoxColumn.Name = "applicationtypeDataGridViewTextBoxColumn";
            // 
            // creditratingDataGridViewTextBoxColumn
            // 
            this.creditratingDataGridViewTextBoxColumn.DataPropertyName = "creditrating";
            this.creditratingDataGridViewTextBoxColumn.HeaderText = "creditrating";
            this.creditratingDataGridViewTextBoxColumn.Name = "creditratingDataGridViewTextBoxColumn";
            // 
            // loanamountDataGridViewTextBoxColumn
            // 
            this.loanamountDataGridViewTextBoxColumn.DataPropertyName = "loanamount";
            this.loanamountDataGridViewTextBoxColumn.HeaderText = "loanamount";
            this.loanamountDataGridViewTextBoxColumn.Name = "loanamountDataGridViewTextBoxColumn";
            // 
            // clientcommentsDataGridViewTextBoxColumn
            // 
            this.clientcommentsDataGridViewTextBoxColumn.DataPropertyName = "clientcomments";
            this.clientcommentsDataGridViewTextBoxColumn.HeaderText = "clientcomments";
            this.clientcommentsDataGridViewTextBoxColumn.Name = "clientcommentsDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // maritalstatusDataGridViewTextBoxColumn
            // 
            this.maritalstatusDataGridViewTextBoxColumn.DataPropertyName = "maritalstatus";
            this.maritalstatusDataGridViewTextBoxColumn.HeaderText = "maritalstatus";
            this.maritalstatusDataGridViewTextBoxColumn.Name = "maritalstatusDataGridViewTextBoxColumn";
            // 
            // numofdependentsDataGridViewTextBoxColumn
            // 
            this.numofdependentsDataGridViewTextBoxColumn.DataPropertyName = "numofdependents";
            this.numofdependentsDataGridViewTextBoxColumn.HeaderText = "numofdependents";
            this.numofdependentsDataGridViewTextBoxColumn.Name = "numofdependentsDataGridViewTextBoxColumn";
            // 
            // driverslicenseDataGridViewTextBoxColumn
            // 
            this.driverslicenseDataGridViewTextBoxColumn.DataPropertyName = "driverslicense";
            this.driverslicenseDataGridViewTextBoxColumn.HeaderText = "driverslicense";
            this.driverslicenseDataGridViewTextBoxColumn.Name = "driverslicenseDataGridViewTextBoxColumn";
            // 
            // residencestatusDataGridViewTextBoxColumn
            // 
            this.residencestatusDataGridViewTextBoxColumn.DataPropertyName = "residencestatus";
            this.residencestatusDataGridViewTextBoxColumn.HeaderText = "residencestatus";
            this.residencestatusDataGridViewTextBoxColumn.Name = "residencestatusDataGridViewTextBoxColumn";
            // 
            // homeaddressDataGridViewTextBoxColumn
            // 
            this.homeaddressDataGridViewTextBoxColumn.DataPropertyName = "homeaddress";
            this.homeaddressDataGridViewTextBoxColumn.HeaderText = "homeaddress";
            this.homeaddressDataGridViewTextBoxColumn.Name = "homeaddressDataGridViewTextBoxColumn";
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            this.suburbDataGridViewTextBoxColumn.DataPropertyName = "suburb";
            this.suburbDataGridViewTextBoxColumn.HeaderText = "suburb";
            this.suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // homephoneDataGridViewTextBoxColumn
            // 
            this.homephoneDataGridViewTextBoxColumn.DataPropertyName = "homephone";
            this.homephoneDataGridViewTextBoxColumn.HeaderText = "homephone";
            this.homephoneDataGridViewTextBoxColumn.Name = "homephoneDataGridViewTextBoxColumn";
            // 
            // mobphoneDataGridViewTextBoxColumn
            // 
            this.mobphoneDataGridViewTextBoxColumn.DataPropertyName = "mobphone";
            this.mobphoneDataGridViewTextBoxColumn.HeaderText = "mobphone";
            this.mobphoneDataGridViewTextBoxColumn.Name = "mobphoneDataGridViewTextBoxColumn";
            // 
            // nextofkinDataGridViewTextBoxColumn
            // 
            this.nextofkinDataGridViewTextBoxColumn.DataPropertyName = "nextofkin";
            this.nextofkinDataGridViewTextBoxColumn.HeaderText = "nextofkin";
            this.nextofkinDataGridViewTextBoxColumn.Name = "nextofkinDataGridViewTextBoxColumn";
            // 
            // nextofkinphoneDataGridViewTextBoxColumn
            // 
            this.nextofkinphoneDataGridViewTextBoxColumn.DataPropertyName = "nextofkinphone";
            this.nextofkinphoneDataGridViewTextBoxColumn.HeaderText = "nextofkinphone";
            this.nextofkinphoneDataGridViewTextBoxColumn.Name = "nextofkinphoneDataGridViewTextBoxColumn";
            // 
            // nextofkinemailDataGridViewTextBoxColumn
            // 
            this.nextofkinemailDataGridViewTextBoxColumn.DataPropertyName = "nextofkinemail";
            this.nextofkinemailDataGridViewTextBoxColumn.HeaderText = "nextofkinemail";
            this.nextofkinemailDataGridViewTextBoxColumn.Name = "nextofkinemailDataGridViewTextBoxColumn";
            // 
            // employmentstatusDataGridViewTextBoxColumn
            // 
            this.employmentstatusDataGridViewTextBoxColumn.DataPropertyName = "employmentstatus";
            this.employmentstatusDataGridViewTextBoxColumn.HeaderText = "employmentstatus";
            this.employmentstatusDataGridViewTextBoxColumn.Name = "employmentstatusDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "occupation";
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // currentemployerDataGridViewTextBoxColumn
            // 
            this.currentemployerDataGridViewTextBoxColumn.DataPropertyName = "currentemployer";
            this.currentemployerDataGridViewTextBoxColumn.HeaderText = "currentemployer";
            this.currentemployerDataGridViewTextBoxColumn.Name = "currentemployerDataGridViewTextBoxColumn";
            // 
            // currentemployerphoneDataGridViewTextBoxColumn
            // 
            this.currentemployerphoneDataGridViewTextBoxColumn.DataPropertyName = "currentemployerphone";
            this.currentemployerphoneDataGridViewTextBoxColumn.HeaderText = "currentemployerphone";
            this.currentemployerphoneDataGridViewTextBoxColumn.Name = "currentemployerphoneDataGridViewTextBoxColumn";
            // 
            // lenderDataGridViewTextBoxColumn
            // 
            this.lenderDataGridViewTextBoxColumn.DataPropertyName = "lender";
            this.lenderDataGridViewTextBoxColumn.HeaderText = "lender";
            this.lenderDataGridViewTextBoxColumn.Name = "lenderDataGridViewTextBoxColumn";
            // 
            // contractnumberDataGridViewTextBoxColumn
            // 
            this.contractnumberDataGridViewTextBoxColumn.DataPropertyName = "contractnumber";
            this.contractnumberDataGridViewTextBoxColumn.HeaderText = "contractnumber";
            this.contractnumberDataGridViewTextBoxColumn.Name = "contractnumberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // faclientprofilesBindingSource
            // 
            this.faclientprofilesBindingSource.DataMember = "fa_client_profiles";
            this.faclientprofilesBindingSource.DataSource = this.dataApplication;
            // 
            // dataApplication
            // 
            this.dataApplication.DataSetName = "DataApplication";
            this.dataApplication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textClientComments);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.textCity);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.textSuburb);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.texthomeaddress);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.textSurname);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.textMiddleName);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.textFirstName);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.textCreditRating);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.textApplicationType);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.textLoanType);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.textLoanStatus);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.textId);
            this.panel.Controls.Add(this.label1);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(878, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(594, 666);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textClientComments
            // 
            this.textClientComments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "clientcomments", true));
            this.textClientComments.Location = new System.Drawing.Point(146, 455);
            this.textClientComments.Multiline = true;
            this.textClientComments.Name = "textClientComments";
            this.textClientComments.Size = new System.Drawing.Size(383, 182);
            this.textClientComments.TabIndex = 11;
            this.textClientComments.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Comments: ";
            // 
            // textCity
            // 
            this.textCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "city", true));
            this.textCity.Location = new System.Drawing.Point(146, 416);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(383, 20);
            this.textCity.TabIndex = 10;
            this.textCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "City:";
            // 
            // textSuburb
            // 
            this.textSuburb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "suburb", true));
            this.textSuburb.Location = new System.Drawing.Point(146, 377);
            this.textSuburb.Name = "textSuburb";
            this.textSuburb.Size = new System.Drawing.Size(383, 20);
            this.textSuburb.TabIndex = 9;
            this.textSuburb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Suburb: ";
            // 
            // texthomeaddress
            // 
            this.texthomeaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "homeaddress", true));
            this.texthomeaddress.Location = new System.Drawing.Point(146, 338);
            this.texthomeaddress.Name = "texthomeaddress";
            this.texthomeaddress.Size = new System.Drawing.Size(383, 20);
            this.texthomeaddress.TabIndex = 8;
            this.texthomeaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Street Address:";
            // 
            // textSurname
            // 
            this.textSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "surname", true));
            this.textSurname.Location = new System.Drawing.Point(146, 299);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(383, 20);
            this.textSurname.TabIndex = 7;
            this.textSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Surname:";
            // 
            // textMiddleName
            // 
            this.textMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "middlename", true));
            this.textMiddleName.Location = new System.Drawing.Point(146, 260);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(383, 20);
            this.textMiddleName.TabIndex = 6;
            this.textMiddleName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Middle Name:";
            // 
            // textFirstName
            // 
            this.textFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "firstname", true));
            this.textFirstName.Location = new System.Drawing.Point(146, 221);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(383, 20);
            this.textFirstName.TabIndex = 5;
            this.textFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name:";
            // 
            // textCreditRating
            // 
            this.textCreditRating.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "creditrating", true));
            this.textCreditRating.Location = new System.Drawing.Point(146, 182);
            this.textCreditRating.Name = "textCreditRating";
            this.textCreditRating.Size = new System.Drawing.Size(383, 20);
            this.textCreditRating.TabIndex = 4;
            this.textCreditRating.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Credit Rating: ";
            // 
            // textApplicationType
            // 
            this.textApplicationType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "applicationtype", true));
            this.textApplicationType.Location = new System.Drawing.Point(146, 143);
            this.textApplicationType.Name = "textApplicationType";
            this.textApplicationType.Size = new System.Drawing.Size(383, 20);
            this.textApplicationType.TabIndex = 3;
            this.textApplicationType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Application Type:";
            // 
            // textLoanType
            // 
            this.textLoanType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "loantype", true));
            this.textLoanType.Location = new System.Drawing.Point(146, 104);
            this.textLoanType.Name = "textLoanType";
            this.textLoanType.Size = new System.Drawing.Size(383, 20);
            this.textLoanType.TabIndex = 2;
            this.textLoanType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loan Type:";
            // 
            // textLoanStatus
            // 
            this.textLoanStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "loanstatus", true));
            this.textLoanStatus.Location = new System.Drawing.Point(146, 65);
            this.textLoanStatus.Name = "textLoanStatus";
            this.textLoanStatus.ReadOnly = true;
            this.textLoanStatus.Size = new System.Drawing.Size(383, 20);
            this.textLoanStatus.TabIndex = 1;
            this.textLoanStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan Status:";
            // 
            // textId
            // 
            this.textId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faclientprofilesBindingSource, "id", true));
            this.textId.Location = new System.Drawing.Point(146, 26);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(383, 20);
            this.textId.TabIndex = 0;
            this.textId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search :";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(116, 35);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(474, 20);
            this.textSearch.TabIndex = 2;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(719, 33);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(92, 23);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(612, 70);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(719, 70);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // fa_client_profilesTableAdapter
            // 
            this.fa_client_profilesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1473, 677);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software FA (MX)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faclientprofilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplication)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textClientComments;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSuburb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox texthomeaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCreditRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApplicationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLoanType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLoanStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button1;
        private DataApplication dataApplication;
        private System.Windows.Forms.BindingSource faclientprofilesBindingSource;
        private DataApplicationTableAdapters.fa_client_profilesTableAdapter fa_client_profilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loantypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientcommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofdependentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverslicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residencestatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextofkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextofkinphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextofkinemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentemployerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentemployerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}

