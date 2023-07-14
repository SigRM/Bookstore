namespace ProyectoV1.UI
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            this.lblID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblExchangeRate = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.dgvTipoCambio = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.txtIdPromotion = new System.Windows.Forms.TextBox();
            this.lblPromotion = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lbltipoConsulta = new System.Windows.Forms.Label();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.colPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 49);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(113, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Payment ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(58, 127);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(86, 25);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "Order ID";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(58, 186);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(160, 25);
            this.lblPaymentMethod.TabIndex = 5;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(555, 48);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 25);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // lblExchangeRate
            // 
            this.lblExchangeRate.AutoSize = true;
            this.lblExchangeRate.Location = new System.Drawing.Point(555, 127);
            this.lblExchangeRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExchangeRate.Name = "lblExchangeRate";
            this.lblExchangeRate.Size = new System.Drawing.Size(145, 25);
            this.lblExchangeRate.TabIndex = 9;
            this.lblExchangeRate.Text = "Exchange Rate";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(255, 45);
            this.txtPaymentID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(240, 29);
            this.txtPaymentID.TabIndex = 2;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(255, 115);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(240, 29);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(255, 186);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(6);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(240, 29);
            this.txtPaymentMethod.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(728, 32);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 29);
            this.txtAmount.TabIndex = 8;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.Location = new System.Drawing.Point(728, 115);
            this.txtExchangeRate.Margin = new System.Windows.Forms.Padding(6);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(240, 29);
            this.txtExchangeRate.TabIndex = 10;
            // 
            // dgvTipoCambio
            // 
            this.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCambio.Location = new System.Drawing.Point(28, 186);
            this.dgvTipoCambio.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTipoCambio.Name = "dgvTipoCambio";
            this.dgvTipoCambio.RowHeadersWidth = 72;
            this.dgvTipoCambio.Size = new System.Drawing.Size(704, 105);
            this.dgvTipoCambio.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrevious,
            this.btnAdd,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1854, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Delete";
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 32);
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 32);
            this.btnAdd.Text = "Add ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 32);
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIdPromotion
            // 
            this.txtIdPromotion.Location = new System.Drawing.Point(728, 182);
            this.txtIdPromotion.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdPromotion.Name = "txtIdPromotion";
            this.txtIdPromotion.Size = new System.Drawing.Size(240, 29);
            this.txtIdPromotion.TabIndex = 14;
            // 
            // lblPromotion
            // 
            this.lblPromotion.AutoSize = true;
            this.lblPromotion.Location = new System.Drawing.Point(555, 186);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(124, 25);
            this.lblPromotion.TabIndex = 15;
            this.lblPromotion.Text = "Promotion ID";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Location = new System.Drawing.Point(23, 42);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(99, 25);
            this.lblInicial.TabIndex = 16;
            this.lblInicial.Text = "Start Date";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(30, 99);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(100, 25);
            this.lblFinal.TabIndex = 17;
            this.lblFinal.Text = "Final Date";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(245, 99);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(397, 29);
            this.dtpFinal.TabIndex = 18;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(245, 42);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(397, 29);
            this.dtpInicial.TabIndex = 19;
            // 
            // lbltipoConsulta
            // 
            this.lbltipoConsulta.AutoSize = true;
            this.lbltipoConsulta.Location = new System.Drawing.Point(30, 318);
            this.lbltipoConsulta.Name = "lbltipoConsulta";
            this.lbltipoConsulta.Size = new System.Drawing.Size(145, 25);
            this.lbltipoConsulta.TabIndex = 20;
            this.lbltipoConsulta.Text = "Exchange Rate";
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Checked = true;
            this.rdbCompra.Location = new System.Drawing.Point(202, 314);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(71, 29);
            this.rdbCompra.TabIndex = 21;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Buy";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(202, 365);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(70, 29);
            this.rdbVenta.TabIndex = 22;
            this.rdbVenta.Text = "Sell";
            this.rdbVenta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(410, 345);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(232, 49);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Find";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentID,
            this.colOrderID,
            this.colMethod,
            this.colAmount});
            this.dgvPayment.Location = new System.Drawing.Point(106, 251);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 72;
            this.dgvPayment.RowTemplate.Height = 31;
            this.dgvPayment.Size = new System.Drawing.Size(775, 431);
            this.dgvPayment.TabIndex = 24;
            this.dgvPayment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.dgvTipoCambio);
            this.groupBox2.Controls.Add(this.lblInicial);
            this.groupBox2.Controls.Add(this.rdbCompra);
            this.groupBox2.Controls.Add(this.rdbVenta);
            this.groupBox2.Controls.Add(this.dtpInicial);
            this.groupBox2.Controls.Add(this.lblFinal);
            this.groupBox2.Controls.Add(this.lbltipoConsulta);
            this.groupBox2.Controls.Add(this.dtpFinal);
            this.groupBox2.Location = new System.Drawing.Point(1073, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 412);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exchange Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPayment);
            this.groupBox3.Controls.Add(this.lblID);
            this.groupBox3.Controls.Add(this.txtIdPromotion);
            this.groupBox3.Controls.Add(this.lblPromotion);
            this.groupBox3.Controls.Add(this.lblOrderID);
            this.groupBox3.Controls.Add(this.txtExchangeRate);
            this.groupBox3.Controls.Add(this.lblPaymentMethod);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.txtPaymentID);
            this.groupBox3.Controls.Add(this.txtOrderID);
            this.groupBox3.Controls.Add(this.txtPaymentMethod);
            this.groupBox3.Controls.Add(this.lblExchangeRate);
            this.groupBox3.Controls.Add(this.lblAmount);
            this.groupBox3.Location = new System.Drawing.Point(12, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 727);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Billing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1073, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 291);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(525, 29);
            this.txtEmail.TabIndex = 1;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(257, 183);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(237, 63);
            this.btnEmail.TabIndex = 2;
            this.btnEmail.Text = "Email Receipt";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click_1);
            // 
            // colPaymentID
            // 
            this.colPaymentID.HeaderText = "Payment ID";
            this.colPaymentID.MinimumWidth = 9;
            this.colPaymentID.Name = "colPaymentID";
            this.colPaymentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaymentID.Width = 175;
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "Order ID";
            this.colOrderID.MinimumWidth = 9;
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOrderID.Width = 175;
            // 
            // colMethod
            // 
            this.colMethod.HeaderText = "Payment Method";
            this.colMethod.MinimumWidth = 9;
            this.colMethod.Name = "colMethod";
            this.colMethod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMethod.Width = 175;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amonunt";
            this.colAmount.MinimumWidth = 9;
            this.colAmount.Name = "colAmount";
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAmount.Width = 175;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoV1.Properties.Resources.Magic_Book__Logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1854, 859);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBilling_FormClosed);
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblExchangeRate;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.DataGridView dgvTipoCambio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TextBox txtIdPromotion;
        private System.Windows.Forms.Label lblPromotion;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label lbltipoConsulta;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
    }
}