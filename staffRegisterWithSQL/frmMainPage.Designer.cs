namespace staffRegisterWithSQL
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdMarried = new System.Windows.Forms.RadioButton();
            this.rdSingle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.msktxtWage = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnIstatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaritialDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonel3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._personelDB_2DataSet = new staffRegisterWithSQL._personelDB_2DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblPersonel_3TableAdapter = new staffRegisterWithSQL._personelDB_2DataSetTableAdapters.tblPersonel_3TableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonel3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._personelDB_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txtJob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdMarried);
            this.groupBox1.Controls.Add(this.rdSingle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.msktxtWage);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Registration";
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJob.Location = new System.Drawing.Point(94, 237);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(123, 25);
            this.txtJob.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Job: ";
            // 
            // rdMarried
            // 
            this.rdMarried.AutoSize = true;
            this.rdMarried.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdMarried.Location = new System.Drawing.Point(153, 176);
            this.rdMarried.Name = "rdMarried";
            this.rdMarried.Size = new System.Drawing.Size(64, 19);
            this.rdMarried.TabIndex = 6;
            this.rdMarried.TabStop = true;
            this.rdMarried.Text = "Married";
            this.rdMarried.UseVisualStyleBackColor = true;
            this.rdMarried.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdSingle
            // 
            this.rdSingle.AutoSize = true;
            this.rdSingle.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSingle.Location = new System.Drawing.Point(94, 175);
            this.rdSingle.Name = "rdSingle";
            this.rdSingle.Size = new System.Drawing.Size(53, 19);
            this.rdSingle.TabIndex = 5;
            this.rdSingle.TabStop = true;
            this.rdSingle.Text = "Single";
            this.rdSingle.UseVisualStyleBackColor = true;
            this.rdSingle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Maritial: ";
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(94, 142);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(123, 25);
            this.cmbCity.TabIndex = 4;
            // 
            // msktxtWage
            // 
            this.msktxtWage.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxtWage.Location = new System.Drawing.Point(94, 206);
            this.msktxtWage.Mask = "00000";
            this.msktxtWage.Name = "msktxtWage";
            this.msktxtWage.Size = new System.Drawing.Size(123, 25);
            this.msktxtWage.TabIndex = 7;
            this.msktxtWage.ValidatingType = typeof(int);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(94, 49);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(123, 25);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Staff Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "City: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salary: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(94, 111);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 25);
            this.txtSurname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Surname: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(94, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 25);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(43, 46);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(122, 28);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGraphics);
            this.groupBox2.Controls.Add(this.btnIstatistics);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proccesses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(40, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "update before pressing update.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "* Double click on the person you want to";
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(43, 251);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(122, 28);
            this.btnGraphics.TabIndex = 15;
            this.btnGraphics.Text = "Graphics";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnIstatistics
            // 
            this.btnIstatistics.Location = new System.Drawing.Point(43, 217);
            this.btnIstatistics.Name = "btnIstatistics";
            this.btnIstatistics.Size = new System.Drawing.Size(122, 28);
            this.btnIstatistics.TabIndex = 14;
            this.btnIstatistics.Text = "Istatistics";
            this.btnIstatistics.UseVisualStyleBackColor = true;
            this.btnIstatistics.Click += new System.EventHandler(this.btnIstatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(43, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Boxes";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(43, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update*";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(43, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalIdDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSurnameDataGridViewTextBoxColumn,
            this.perCityDataGridViewTextBoxColumn,
            this.perMaritialDataGridViewCheckBoxColumn,
            this.perJobDataGridViewTextBoxColumn,
            this.Salary});
            this.dataGridView1.DataSource = this.tblPersonel3BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 142);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personalIdDataGridViewTextBoxColumn
            // 
            this.personalIdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.personalIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.personalIdDataGridViewTextBoxColumn.Name = "personalIdDataGridViewTextBoxColumn";
            this.personalIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSurnameDataGridViewTextBoxColumn
            // 
            this.perSurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.perSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.perSurnameDataGridViewTextBoxColumn.Name = "perSurnameDataGridViewTextBoxColumn";
            // 
            // perCityDataGridViewTextBoxColumn
            // 
            this.perCityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.perCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.perCityDataGridViewTextBoxColumn.Name = "perCityDataGridViewTextBoxColumn";
            // 
            // perMaritialDataGridViewCheckBoxColumn
            // 
            this.perMaritialDataGridViewCheckBoxColumn.DataPropertyName = "Maritial";
            this.perMaritialDataGridViewCheckBoxColumn.HeaderText = "Maritial";
            this.perMaritialDataGridViewCheckBoxColumn.Name = "perMaritialDataGridViewCheckBoxColumn";
            // 
            // perJobDataGridViewTextBoxColumn
            // 
            this.perJobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.perJobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.perJobDataGridViewTextBoxColumn.Name = "perJobDataGridViewTextBoxColumn";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // tblPersonel3BindingSource
            // 
            this.tblPersonel3BindingSource.DataMember = "tblPersonel-3";
            this.tblPersonel3BindingSource.DataSource = this._personelDB_2DataSet;
            // 
            // _personelDB_2DataSet
            // 
            this._personelDB_2DataSet.DataSetName = "_personelDB_2DataSet";
            this._personelDB_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(580, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tblPersonel_3TableAdapter
            // 
            this.tblPersonel_3TableAdapter.ClearBeforeFill = true;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(783, 511);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainPage";
            this.Text = "Management Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonel3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._personelDB_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMarried;
        private System.Windows.Forms.RadioButton rdSingle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.MaskedTextBox msktxtWage;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnIstatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private _personelDB_2DataSet _personelDB_2DataSet;
        private System.Windows.Forms.BindingSource tblPersonel3BindingSource;
        private _personelDB_2DataSetTableAdapters.tblPersonel_3TableAdapter tblPersonel_3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMaritialDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

