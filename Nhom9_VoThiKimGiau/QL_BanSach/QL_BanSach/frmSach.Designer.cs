namespace QL_BanSach
{
    partial class frmSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labTG = new System.Windows.Forms.Label();
            this.labMS = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.labDM = new System.Windows.Forms.Label();
            this.labTS = new System.Windows.Forms.Label();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.labGB = new System.Windows.Forms.Label();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDM = new System.Windows.Forms.TextBox();
            this.LabSL = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tabLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(12, 231);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.Size = new System.Drawing.Size(805, 217);
            this.dgvSach.TabIndex = 66;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            // 
            // tabLayout
            // 
            this.tabLayout.ColumnCount = 6;
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.78802F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.21198F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tabLayout.Controls.Add(this.labTG, 0, 1);
            this.tabLayout.Controls.Add(this.labMS, 0, 0);
            this.tabLayout.Controls.Add(this.txtMS, 1, 0);
            this.tabLayout.Controls.Add(this.txtTG, 1, 1);
            this.tabLayout.Controls.Add(this.labDM, 2, 1);
            this.tabLayout.Controls.Add(this.labTS, 2, 0);
            this.tabLayout.Controls.Add(this.txtTS, 3, 0);
            this.tabLayout.Controls.Add(this.labGB, 4, 0);
            this.tabLayout.Controls.Add(this.txtGB, 5, 0);
            this.tabLayout.Controls.Add(this.txtSL, 5, 1);
            this.tabLayout.Controls.Add(this.txtDM, 3, 1);
            this.tabLayout.Controls.Add(this.LabSL, 4, 1);
            this.tabLayout.Location = new System.Drawing.Point(12, 96);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.RowCount = 2;
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayout.Size = new System.Drawing.Size(805, 113);
            this.tabLayout.TabIndex = 65;
            // 
            // labTG
            // 
            this.labTG.AutoSize = true;
            this.labTG.Location = new System.Drawing.Point(3, 60);
            this.labTG.Name = "labTG";
            this.labTG.Size = new System.Drawing.Size(98, 53);
            this.labTG.TabIndex = 7;
            this.labTG.Text = "Tên tác giả";
            // 
            // labMS
            // 
            this.labMS.AutoSize = true;
            this.labMS.Location = new System.Drawing.Point(3, 0);
            this.labMS.Name = "labMS";
            this.labMS.Size = new System.Drawing.Size(69, 60);
            this.labMS.TabIndex = 0;
            this.labMS.Text = "Mã sách";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(111, 3);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(143, 44);
            this.txtMS.TabIndex = 1;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(111, 63);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(143, 44);
            this.txtTG.TabIndex = 4;
            // 
            // labDM
            // 
            this.labDM.AutoSize = true;
            this.labDM.Location = new System.Drawing.Point(288, 60);
            this.labDM.Name = "labDM";
            this.labDM.Size = new System.Drawing.Size(131, 53);
            this.labDM.TabIndex = 5;
            this.labDM.Text = "Tên danh mục";
            // 
            // labTS
            // 
            this.labTS.AutoSize = true;
            this.labTS.Location = new System.Drawing.Point(288, 0);
            this.labTS.Name = "labTS";
            this.labTS.Size = new System.Drawing.Size(125, 36);
            this.labTS.TabIndex = 3;
            this.labTS.Text = "Tên sách";
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(429, 3);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(143, 44);
            this.txtTS.TabIndex = 8;
            // 
            // labGB
            // 
            this.labGB.AutoSize = true;
            this.labGB.Location = new System.Drawing.Point(597, 0);
            this.labGB.Name = "labGB";
            this.labGB.Size = new System.Drawing.Size(114, 36);
            this.labGB.TabIndex = 9;
            this.labGB.Text = "Giá bán";
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(727, 3);
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(71, 44);
            this.txtGB.TabIndex = 11;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(727, 63);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(71, 44);
            this.txtSL.TabIndex = 12;
            // 
            // txtDM
            // 
            this.txtDM.Location = new System.Drawing.Point(429, 63);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(143, 44);
            this.txtDM.TabIndex = 13;
            // 
            // LabSL
            // 
            this.LabSL.AutoSize = true;
            this.LabSL.Location = new System.Drawing.Point(597, 60);
            this.LabSL.Name = "LabSL";
            this.LabSL.Size = new System.Drawing.Size(96, 53);
            this.LabSL.TabIndex = 10;
            this.LabSL.Text = "Số lượng kho";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(559, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 46);
            this.btnPrint.TabIndex = 64;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(695, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 46);
            this.btnLogout.TabIndex = 63;
            this.btnLogout.Text = "Về điều hướng";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 46);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 46);
            this.btnInsert.TabIndex = 59;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 655);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.Text = "Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSach_FormClosing);
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TableLayoutPanel tabLayout;
        private System.Windows.Forms.Label labMS;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label labTS;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.Label labDM;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label labTG;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Label labGB;
        private System.Windows.Forms.Label LabSL;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtDM;
    }
}

