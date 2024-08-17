namespace QL_BanSach
{
    partial class frmTG
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
            this.dgvTG = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.labTG = new System.Windows.Forms.Label();
            this.labMTG = new System.Windows.Forms.Label();
            this.txtMTG = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.tabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).BeginInit();
            this.tabLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTG
            // 
            this.dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTG.Location = new System.Drawing.Point(12, 186);
            this.dgvTG.Name = "dgvTG";
            this.dgvTG.RowHeadersWidth = 51;
            this.dgvTG.Size = new System.Drawing.Size(776, 217);
            this.dgvTG.TabIndex = 73;
            this.dgvTG.SelectionChanged += new System.EventHandler(this.dgvTG_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(559, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 46);
            this.btnPrint.TabIndex = 72;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 46);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Về điều hướng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 46);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(157, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 46);
            this.btnInsert.TabIndex = 67;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // labTG
            // 
            this.labTG.AutoSize = true;
            this.labTG.Location = new System.Drawing.Point(265, 0);
            this.labTG.Name = "labTG";
            this.labTG.Size = new System.Drawing.Size(116, 64);
            this.labTG.TabIndex = 77;
            this.labTG.Text = "Tên tác giả";
            // 
            // labMTG
            // 
            this.labMTG.AutoSize = true;
            this.labMTG.Location = new System.Drawing.Point(3, 0);
            this.labMTG.Name = "labMTG";
            this.labMTG.Size = new System.Drawing.Size(102, 64);
            this.labMTG.TabIndex = 74;
            this.labMTG.Text = "Mã tác giả";
            // 
            // txtMTG
            // 
            this.txtMTG.Location = new System.Drawing.Point(112, 3);
            this.txtMTG.Name = "txtMTG";
            this.txtMTG.Size = new System.Drawing.Size(143, 44);
            this.txtMTG.TabIndex = 75;
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(393, 3);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(143, 44);
            this.txtTG.TabIndex = 76;
            // 
            // tabLayout
            // 
            this.tabLayout.ColumnCount = 4;
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.44487F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.55513F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tabLayout.Controls.Add(this.labMTG, 0, 0);
            this.tabLayout.Controls.Add(this.txtTG, 3, 0);
            this.tabLayout.Controls.Add(this.labTG, 2, 0);
            this.tabLayout.Controls.Add(this.txtMTG, 1, 0);
            this.tabLayout.Location = new System.Drawing.Point(105, 93);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.RowCount = 1;
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tabLayout.Size = new System.Drawing.Size(547, 64);
            this.tabLayout.TabIndex = 78;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 474);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.dgvTG);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTG";
            this.Text = "frmTG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTG_FormClosing);
            this.Load += new System.EventHandler(this.frmTG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).EndInit();
            this.tabLayout.ResumeLayout(false);
            this.tabLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTG;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label labTG;
        private System.Windows.Forms.Label labMTG;
        private System.Windows.Forms.TextBox txtMTG;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TableLayoutPanel tabLayout;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}