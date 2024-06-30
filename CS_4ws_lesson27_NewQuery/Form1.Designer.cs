namespace CS_4ws_lesson27_NewQuery
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDemSoSanPham = new System.Windows.Forms.Button();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.lbSoSanPham = new System.Windows.Forms.Label();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_GoToForm2 = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grTacVu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(29, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 42);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(29, 92);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 45);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dang Nhap";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(162, 106);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 16);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status Connect";
            // 
            // btnDemSoSanPham
            // 
            this.btnDemSoSanPham.Location = new System.Drawing.Point(21, 56);
            this.btnDemSoSanPham.Name = "btnDemSoSanPham";
            this.btnDemSoSanPham.Size = new System.Drawing.Size(185, 64);
            this.btnDemSoSanPham.TabIndex = 1;
            this.btnDemSoSanPham.Text = "Dem so San Pham";
            this.btnDemSoSanPham.UseVisualStyleBackColor = true;
            this.btnDemSoSanPham.Click += new System.EventHandler(this.btnDemSoSanPham_Click);
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Location = new System.Drawing.Point(349, 80);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(35, 16);
            this.lblSoSanPham.TabIndex = 2;
            this.lblSoSanPham.Text = "____";
            // 
            // lbSoSanPham
            // 
            this.lbSoSanPham.AutoSize = true;
            this.lbSoSanPham.Location = new System.Drawing.Point(232, 80);
            this.lbSoSanPham.Name = "lbSoSanPham";
            this.lbSoSanPham.Size = new System.Drawing.Size(89, 16);
            this.lbSoSanPham.TabIndex = 3;
            this.lbSoSanPham.Text = "Số sản phẩm:";
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnDemSoSanPham);
            this.grTacVu.Controls.Add(this.lblSoSanPham);
            this.grTacVu.Controls.Add(this.lbSoSanPham);
            this.grTacVu.Enabled = false;
            this.grTacVu.Location = new System.Drawing.Point(317, 12);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(400, 175);
            this.grTacVu.TabIndex = 5;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tac vu";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(561, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created by: Huy Nguyen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 284);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_GoToForm2
            // 
            this.btn_GoToForm2.Location = new System.Drawing.Point(233, 193);
            this.btn_GoToForm2.Name = "btn_GoToForm2";
            this.btn_GoToForm2.Size = new System.Drawing.Size(135, 45);
            this.btn_GoToForm2.TabIndex = 9;
            this.btn_GoToForm2.Text = "Go to Form2";
            this.btn_GoToForm2.UseVisualStyleBackColor = true;
            this.btn_GoToForm2.Click += new System.EventHandler(this.btn_GoToForm2_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(18, 215);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(144, 32);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Load all data to table";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(402, 193);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(121, 45);
            this.btnForm3.TabIndex = 11;
            this.btnForm3.Text = "Go to Form3";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 573);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btn_GoToForm2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grTacVu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grTacVu.ResumeLayout(false);
            this.grTacVu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDemSoSanPham;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.Label lbSoSanPham;
        private System.Windows.Forms.GroupBox grTacVu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_GoToForm2;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnForm3;
    }
}

