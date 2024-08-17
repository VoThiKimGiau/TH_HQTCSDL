
namespace QL_BanSach
{
    partial class frmThongKe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdDTHT = new System.Windows.Forms.RadioButton();
            this.rdKH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 453);
            this.dataGridView1.TabIndex = 2;
            // 
            // rdDTHT
            // 
            this.rdDTHT.AutoSize = true;
            this.rdDTHT.Location = new System.Drawing.Point(198, 155);
            this.rdDTHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdDTHT.Name = "rdDTHT";
            this.rdDTHT.Size = new System.Drawing.Size(256, 29);
            this.rdDTHT.TabIndex = 3;
            this.rdDTHT.TabStop = true;
            this.rdDTHT.Text = "Doanh thu hàng tháng";
            this.rdDTHT.UseVisualStyleBackColor = true;
            this.rdDTHT.CheckedChanged += new System.EventHandler(this.rdDTHT_CheckedChanged);
            // 
            // rdKH
            // 
            this.rdKH.AutoSize = true;
            this.rdKH.Location = new System.Drawing.Point(578, 155);
            this.rdKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdKH.Name = "rdKH";
            this.rdKH.Size = new System.Drawing.Size(308, 29);
            this.rdKH.TabIndex = 4;
            this.rdKH.TabStop = true;
            this.rdKH.Text = "Doanh thu từng khách hàng";
            this.rdKH.UseVisualStyleBackColor = true;
            this.rdKH.CheckedChanged += new System.EventHandler(this.rdKH_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(466, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 76);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1062, 127);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 95);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Về điều hướng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(934, 127);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(118, 95);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdKH);
            this.Controls.Add(this.rdDTHT);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKe";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdDTHT;
        private System.Windows.Forms.RadioButton rdKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
    }
}

