namespace QL_BanSach
{
    partial class frmDMS
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
            this.tabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labMDM = new System.Windows.Forms.Label();
            this.txtTDM = new System.Windows.Forms.TextBox();
            this.labTDM = new System.Windows.Forms.Label();
            this.txtMDM = new System.Windows.Forms.TextBox();
            this.dgvDM = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLayout
            // 
            this.tabLayout.ColumnCount = 4;
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.98626F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.01374F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tabLayout.Controls.Add(this.labMDM, 0, 0);
            this.tabLayout.Controls.Add(this.txtTDM, 3, 0);
            this.tabLayout.Controls.Add(this.labTDM, 2, 0);
            this.tabLayout.Controls.Add(this.txtMDM, 1, 0);
            this.tabLayout.Location = new System.Drawing.Point(78, 93);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.RowCount = 1;
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tabLayout.Size = new System.Drawing.Size(657, 64);
            this.tabLayout.TabIndex = 86;
            // 
            // labMDM
            // 
            this.labMDM.AutoSize = true;
            this.labMDM.Location = new System.Drawing.Point(3, 0);
            this.labMDM.Name = "labMDM";
            this.labMDM.Size = new System.Drawing.Size(83, 64);
            this.labMDM.TabIndex = 74;
            this.labMDM.Text = "Mã danh mục";
            // 
            // txtTDM
            // 
            this.txtTDM.Location = new System.Drawing.Point(428, 3);
            this.txtTDM.Name = "txtTDM";
            this.txtTDM.Size = new System.Drawing.Size(208, 44);
            this.txtTDM.TabIndex = 76;
            // 
            // labTDM
            // 
            this.labTDM.AutoSize = true;
            this.labTDM.Location = new System.Drawing.Point(293, 0);
            this.labTDM.Name = "labTDM";
            this.labTDM.Size = new System.Drawing.Size(83, 64);
            this.labTDM.TabIndex = 77;
            this.labTDM.Text = "Tên danh mục";
            // 
            // txtMDM
            // 
            this.txtMDM.Location = new System.Drawing.Point(131, 3);
            this.txtMDM.Name = "txtMDM";
            this.txtMDM.Size = new System.Drawing.Size(156, 44);
            this.txtMDM.TabIndex = 75;
            // 
            // dgvDM
            // 
            this.dgvDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDM.Location = new System.Drawing.Point(12, 186);
            this.dgvDM.Name = "dgvDM";
            this.dgvDM.RowHeadersWidth = 51;
            this.dgvDM.Size = new System.Drawing.Size(776, 217);
            this.dgvDM.TabIndex = 85;
            this.dgvDM.SelectionChanged += new System.EventHandler(this.dgvDM_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(559, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 46);
            this.btnPrint.TabIndex = 84;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 46);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "Về điều hướng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 46);
            this.btnSave.TabIndex = 82;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 46);
            this.btnInsert.TabIndex = 79;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.dgvDM);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDMS";
            this.Text = "frmDMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDMS_FormClosing);
            this.Load += new System.EventHandler(this.frmDMS_Load);
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayout;
        private System.Windows.Forms.Label labMDM;
        private System.Windows.Forms.TextBox txtTDM;
        private System.Windows.Forms.Label labTDM;
        private System.Windows.Forms.TextBox txtMDM;
        private System.Windows.Forms.DataGridView dgvDM;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}