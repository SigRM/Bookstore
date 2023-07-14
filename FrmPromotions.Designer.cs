namespace ProyectoV1.UI
{
    partial class FrmPromotions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromotions));
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblStarDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.datetimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.datetimeStarDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnExportToPDF = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(50, 81);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(50, 168);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount";
            // 
            // lblStarDate
            // 
            this.lblStarDate.AutoSize = true;
            this.lblStarDate.Location = new System.Drawing.Point(431, 81);
            this.lblStarDate.Name = "lblStarDate";
            this.lblStarDate.Size = new System.Drawing.Size(52, 13);
            this.lblStarDate.TabIndex = 7;
            this.lblStarDate.Text = "Star Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(431, 161);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "End Date";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(165, 161);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 6;
            // 
            // datetimeEndDate
            // 
            this.datetimeEndDate.Location = new System.Drawing.Point(514, 155);
            this.datetimeEndDate.Name = "datetimeEndDate";
            this.datetimeEndDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeEndDate.TabIndex = 10;
            // 
            // datetimeStarDate
            // 
            this.datetimeStarDate.Location = new System.Drawing.Point(514, 75);
            this.datetimeStarDate.Name = "datetimeStarDate";
            this.datetimeStarDate.Size = new System.Drawing.Size(200, 20);
            this.datetimeStarDate.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBack,
            this.btnCreate,
            this.btnDelete,
            this.btnUpdate,
            this.btnExportToPDF});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBack
            // 
            this.btnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(23, 22);
            this.btnGoBack.Text = "Go back";
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
            this.btnUpdate.Image = global::ProyectoV1.Properties.Resources.available_updates;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 22);
            this.btnUpdate.Text = "Update";
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportToPDF.Image = global::ProyectoV1.Properties.Resources.export_pdf;
            this.btnExportToPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.Size = new System.Drawing.Size(23, 22);
            this.btnExportToPDF.Text = "Export to PDF";
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colDiscount,
            this.colStart,
            this.colEnd});
            this.dataGridView1.Location = new System.Drawing.Point(53, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 161);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Start Date";
            this.colStart.Name = "colStart";
            this.colStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End Date";
            this.colEnd.Name = "colEnd";
            this.colEnd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmPromotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::ProyectoV1.Properties.Resources.Magic_Book__Logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.datetimeStarDate);
            this.Controls.Add(this.datetimeEndDate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStarDate);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FrmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromotions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPromotions_FormClosed);
            this.Load += new System.EventHandler(this.FrmPromotions_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblStarDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DateTimePicker datetimeEndDate;
        private System.Windows.Forms.DateTimePicker datetimeStarDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnGoBack;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnExportToPDF;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
    }
}