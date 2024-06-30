namespace CS_4ws_lesson27_NewQuery
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnLoadAllData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoToForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 325);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnLoadAllData
            // 
            this.btnLoadAllData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadAllData.Name = "btnLoadAllData";
            this.btnLoadAllData.Size = new System.Drawing.Size(160, 57);
            this.btnLoadAllData.TabIndex = 1;
            this.btnLoadAllData.Text = "Load all data to Listview";
            this.btnLoadAllData.UseVisualStyleBackColor = true;
            this.btnLoadAllData.Click += new System.EventHandler(this.btnLoadAllData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(604, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 57);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Don gia";
            this.columnHeader3.Width = 179;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ma Danh Muc";
            this.columnHeader4.Width = 273;
            // 
            // btnGoToForm4
            // 
            this.btnGoToForm4.Location = new System.Drawing.Point(248, 12);
            this.btnGoToForm4.Name = "btnGoToForm4";
            this.btnGoToForm4.Size = new System.Drawing.Size(100, 57);
            this.btnGoToForm4.TabIndex = 3;
            this.btnGoToForm4.Text = "GoToForm4";
            this.btnGoToForm4.UseVisualStyleBackColor = true;
            this.btnGoToForm4.Click += new System.EventHandler(this.btnGoToForm4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.btnGoToForm4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadAllData);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLoadAllData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGoToForm4;
    }
}