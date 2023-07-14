namespace ProyectoV1.UI
{
    partial class FrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.datetimeHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnExportToPDF = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmail = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(26, 212);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(154, 205);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colHireDate,
            this.colSalary,
            this.colManagerID});
            this.dataGridView1.Location = new System.Drawing.Point(29, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 171);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Location = new System.Drawing.Point(404, 161);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(63, 13);
            this.lblManagerID.TabIndex = 12;
            this.lblManagerID.Text = "Manager ID";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(404, 113);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(404, 63);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 8;
            this.lblHireDate.Text = "Hire Date";
            // 
            // datetimeHireDate
            // 
            this.datetimeHireDate.Location = new System.Drawing.Point(525, 57);
            this.datetimeHireDate.Name = "datetimeHireDate";
            this.datetimeHireDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeHireDate.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(525, 110);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 20);
            this.txtSalary.TabIndex = 11;
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(525, 158);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(200, 20);
            this.txtManagerID.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBack,
            this.btnCreate,
            this.btnDelete,
            this.btnUpdate,
            this.btnExportToPDF,
            this.btnEmail});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBack
            // 
            this.btnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(23, 22);
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(23, 22);
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 22);
            this.btnUpdate.Text = "Update";
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportToPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToPDF.Image")));
            this.btnExportToPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(23, 22);
            this.btnExportToPDF.Text = "Generate pdf ";
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHireDate
            // 
            this.colHireDate.HeaderText = "Hire Date";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSalary
            // 
            this.colSalary.HeaderText = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colManagerID
            // 
            this.colManagerID.HeaderText = "Manager ID";
            this.colManagerID.Name = "colManagerID";
            this.colManagerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnEmail
            // 
            this.btnEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(23, 22);
            this.btnEmail.Text = "Send Email";
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoV1.Properties.Resources.Magic_Book__Logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.datetimeHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblManagerID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FrmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmployees_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker datetimeHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGoBack;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnExportToPDF;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerID;
        private System.Windows.Forms.ToolStripButton btnEmail;
    }
}