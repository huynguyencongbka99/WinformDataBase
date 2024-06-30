namespace CS_4ws_lesson27_NewQuery
{
    partial class frm2
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(137, 49);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(131, 22);
            this.txtMa.TabIndex = 0;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(31, 49);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(26, 16);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Ma";
            this.lblMa.Click += new System.EventHandler(this.lblMa_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(31, 87);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Ten";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(137, 87);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(131, 22);
            this.txtTen.TabIndex = 3;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(31, 125);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(54, 16);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Don gia";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(137, 125);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(131, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // lblMaDanhMuc
            // 
            this.lblMaDanhMuc.AutoSize = true;
            this.lblMaDanhMuc.Location = new System.Drawing.Point(31, 163);
            this.lblMaDanhMuc.Name = "lblMaDanhMuc";
            this.lblMaDanhMuc.Size = new System.Drawing.Size(89, 16);
            this.lblMaDanhMuc.TabIndex = 2;
            this.lblMaDanhMuc.Text = "Ma Danh Muc";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Enabled = false;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(137, 163);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(131, 22);
            this.txtMaDanhMuc.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(302, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(125, 136);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblMaDanhMuc);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMa);
            this.Name = "frm2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblMaDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
    }
}