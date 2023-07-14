namespace ProyectoV1.UI
{
    partial class FrmQRPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRPromotion));
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.txtEnterCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateCodeBar = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateQR = new System.Windows.Forms.ToolStripButton();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.btnSaveCodeBar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.BackColor = System.Drawing.Color.White;
            this.lblEnterCode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.Location = new System.Drawing.Point(71, 50);
            this.lblEnterCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(219, 68);
            this.lblEnterCode.TabIndex = 1;
            this.lblEnterCode.Text = "Enter here your promotion \r\ncode and reclaim the discount\r\nin your order with the" +
    " QR or the\r\nCode Bar\r\n";
            // 
            // txtEnterCode
            // 
            this.txtEnterCode.Location = new System.Drawing.Point(90, 149);
            this.txtEnterCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.Size = new System.Drawing.Size(182, 20);
            this.txtEnterCode.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(90, 203);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnGenerateCodeBar,
            this.btnGenerateQR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(375, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Go back to the main menu";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateCodeBar
            // 
            this.btnGenerateCodeBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenerateCodeBar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateCodeBar.Image")));
            this.btnGenerateCodeBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateCodeBar.Name = "btnGenerateCodeBar";
            this.btnGenerateCodeBar.Size = new System.Drawing.Size(23, 22);
            this.btnGenerateCodeBar.Text = "Generate Code Bar";
            this.btnGenerateCodeBar.Click += new System.EventHandler(this.btnGenerateCodeBar_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenerateQR.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateQR.Image")));
            this.btnGenerateQR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(23, 22);
            this.btnGenerateQR.Text = "Generate QR code";
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(51, 383);
            this.btnSaveQR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(257, 34);
            this.btnSaveQR.TabIndex = 3;
            this.btnSaveQR.Text = "Save QR";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // btnSaveCodeBar
            // 
            this.btnSaveCodeBar.Location = new System.Drawing.Point(51, 439);
            this.btnSaveCodeBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveCodeBar.Name = "btnSaveCodeBar";
            this.btnSaveCodeBar.Size = new System.Drawing.Size(257, 34);
            this.btnSaveCodeBar.TabIndex = 4;
            this.btnSaveCodeBar.Text = "Save Code Bar";
            this.btnSaveCodeBar.UseVisualStyleBackColor = true;
            this.btnSaveCodeBar.Click += new System.EventHandler(this.btnSaveCodeBar_Click);
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 485);
            this.Controls.Add(this.btnSaveCodeBar);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtEnterCode);
            this.Controls.Add(this.lblEnterCode);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQR";
            this.Load += new System.EventHandler(this.FrmQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.TextBox txtEnterCode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnGenerateCodeBar;
        private System.Windows.Forms.ToolStripButton btnGenerateQR;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Button btnSaveCodeBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}