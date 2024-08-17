namespace QL_BanSach
{
    partial class frm_Sach
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
            System.Windows.Forms.GroupBox groupBox1;
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_danhmuc = new System.Windows.Forms.ComboBox();
            this.cbb_tacgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_slkho = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_slsachdh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_soluongsachdh = new System.Windows.Forms.Button();
            this.txt_tongtienhd = new System.Windows.Forms.TextBox();
            this.btn_tonghd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.btn_inhd = new System.Windows.Forms.Button();
            this.btn_xoahd = new System.Windows.Forms.Button();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_qlsach = new System.Windows.Forms.Button();
            this.btn_bansach = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.btn_them);
            groupBox1.Controls.Add(this.btn_sua);
            groupBox1.Controls.Add(this.btn_xoa);
            groupBox1.Controls.Add(this.dgv_sach);
            groupBox1.Controls.Add(this.cbb_danhmuc);
            groupBox1.Controls.Add(this.cbb_tacgia);
            groupBox1.Controls.Add(this.label4);
            groupBox1.Controls.Add(this.label5);
            groupBox1.Controls.Add(this.txt_slkho);
            groupBox1.Controls.Add(this.txt_gia);
            groupBox1.Controls.Add(this.txt_tensach);
            groupBox1.Controls.Add(this.label3);
            groupBox1.Controls.Add(this.label2);
            groupBox1.Controls.Add(this.label1);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(26, 264);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1155, 1021);
            groupBox1.TabIndex = 67;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Sách";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QL_BanSach.Properties.Resources.insert_g;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(72, 460);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(231, 78);
            this.btn_them.TabIndex = 80;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QL_BanSach.Properties.Resources.update_g;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(706, 460);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(231, 78);
            this.btn_sua.TabIndex = 79;
            this.btn_sua.Text = "Sữa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QL_BanSach.Properties.Resources.delete_g;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(395, 460);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(231, 78);
            this.btn_xoa.TabIndex = 78;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgv_sach
            // 
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.SLKho,
            this.MaTG,
            this.MaDanhMuc});
            this.dgv_sach.Location = new System.Drawing.Point(77, 557);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.RowTemplate.Height = 33;
            this.dgv_sach.Size = new System.Drawing.Size(1054, 428);
            this.dgv_sach.TabIndex = 77;
            this.dgv_sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sach_CellContentClick);
            this.dgv_sach.SelectionChanged += new System.EventHandler(this.dgv_sach_SelectionChanged);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã ";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 70;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 250;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 70;
            // 
            // SLKho
            // 
            this.SLKho.DataPropertyName = "SLKho";
            this.SLKho.HeaderText = "Tồn";
            this.SLKho.Name = "SLKho";
            this.SLKho.Width = 70;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Tác Giả";
            this.MaTG.Name = "MaTG";
            this.MaTG.Width = 70;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Danh Mục";
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.Width = 70;
            // 
            // cbb_danhmuc
            // 
            this.cbb_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_danhmuc.FormattingEnabled = true;
            this.cbb_danhmuc.Location = new System.Drawing.Point(292, 391);
            this.cbb_danhmuc.Name = "cbb_danhmuc";
            this.cbb_danhmuc.Size = new System.Drawing.Size(510, 39);
            this.cbb_danhmuc.TabIndex = 76;
            // 
            // cbb_tacgia
            // 
            this.cbb_tacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tacgia.FormattingEnabled = true;
            this.cbb_tacgia.Location = new System.Drawing.Point(292, 312);
            this.cbb_tacgia.Name = "cbb_tacgia";
            this.cbb_tacgia.Size = new System.Drawing.Size(510, 39);
            this.cbb_tacgia.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 37);
            this.label4.TabIndex = 74;
            this.label4.Text = "Danh Mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 37);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tác Giả";
            // 
            // txt_slkho
            // 
            this.txt_slkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slkho.Location = new System.Drawing.Point(292, 224);
            this.txt_slkho.Multiline = true;
            this.txt_slkho.Name = "txt_slkho";
            this.txt_slkho.Size = new System.Drawing.Size(510, 49);
            this.txt_slkho.TabIndex = 72;
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(292, 129);
            this.txt_gia.Multiline = true;
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(510, 49);
            this.txt_gia.TabIndex = 71;
            // 
            // txt_tensach
            // 
            this.txt_tensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensach.Location = new System.Drawing.Point(292, 35);
            this.txt_tensach.Multiline = true;
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(510, 49);
            this.txt_tensach.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 69;
            this.label3.Text = "SL Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 37);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giá Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tên Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_slsachdh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_soluongsachdh);
            this.groupBox2.Controls.Add(this.txt_tongtienhd);
            this.groupBox2.Controls.Add(this.btn_tonghd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_maHD);
            this.groupBox2.Controls.Add(this.btn_inhd);
            this.groupBox2.Controls.Add(this.btn_xoahd);
            this.groupBox2.Controls.Add(this.dgv_HoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1187, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 1021);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // txt_slsachdh
            // 
            this.txt_slsachdh.Location = new System.Drawing.Point(737, 712);
            this.txt_slsachdh.Name = "txt_slsachdh";
            this.txt_slsachdh.Size = new System.Drawing.Size(231, 38);
            this.txt_slsachdh.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 31);
            this.label7.TabIndex = 87;
            this.label7.Text = "SL Sách ĐH";
            // 
            // btn_soluongsachdh
            // 
            this.btn_soluongsachdh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_soluongsachdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soluongsachdh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_soluongsachdh.Location = new System.Drawing.Point(737, 618);
            this.btn_soluongsachdh.Name = "btn_soluongsachdh";
            this.btn_soluongsachdh.Size = new System.Drawing.Size(231, 78);
            this.btn_soluongsachdh.TabIndex = 86;
            this.btn_soluongsachdh.Text = "Tổng";
            this.btn_soluongsachdh.UseVisualStyleBackColor = false;
            this.btn_soluongsachdh.Click += new System.EventHandler(this.btn_soluongsachdh_Click);
            // 
            // txt_tongtienhd
            // 
            this.txt_tongtienhd.Location = new System.Drawing.Point(737, 535);
            this.txt_tongtienhd.Name = "txt_tongtienhd";
            this.txt_tongtienhd.Size = new System.Drawing.Size(231, 38);
            this.txt_tongtienhd.TabIndex = 85;
            // 
            // btn_tonghd
            // 
            this.btn_tonghd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_tonghd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tonghd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tonghd.Location = new System.Drawing.Point(737, 434);
            this.btn_tonghd.Name = "btn_tonghd";
            this.btn_tonghd.Size = new System.Drawing.Size(231, 78);
            this.btn_tonghd.TabIndex = 84;
            this.btn_tonghd.Text = "Tổng";
            this.btn_tonghd.UseVisualStyleBackColor = false;
            this.btn_tonghd.Click += new System.EventHandler(this.btn_tonghd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(742, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 83;
            this.label6.Text = "Tổng Tiền";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Enabled = false;
            this.txt_maHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHD.Location = new System.Drawing.Point(737, 65);
            this.txt_maHD.Multiline = true;
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(231, 69);
            this.txt_maHD.TabIndex = 82;
            // 
            // btn_inhd
            // 
            this.btn_inhd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_inhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inhd.Location = new System.Drawing.Point(737, 290);
            this.btn_inhd.Name = "btn_inhd";
            this.btn_inhd.Size = new System.Drawing.Size(231, 78);
            this.btn_inhd.TabIndex = 80;
            this.btn_inhd.Text = "IN HĐ";
            this.btn_inhd.UseVisualStyleBackColor = false;
            this.btn_inhd.Click += new System.EventHandler(this.btn_inhd_Click);
            // 
            // btn_xoahd
            // 
            this.btn_xoahd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoahd.Image = global::QL_BanSach.Properties.Resources.delete_g;
            this.btn_xoahd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoahd.Location = new System.Drawing.Point(737, 173);
            this.btn_xoahd.Name = "btn_xoahd";
            this.btn_xoahd.Size = new System.Drawing.Size(231, 78);
            this.btn_xoahd.TabIndex = 79;
            this.btn_xoahd.Text = "Xóa HĐ";
            this.btn_xoahd.UseVisualStyleBackColor = false;
            this.btn_xoahd.Click += new System.EventHandler(this.btn_xoahd_Click);
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(39, 65);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowTemplate.Height = 33;
            this.dgv_HoaDon.Size = new System.Drawing.Size(666, 920);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.SelectionChanged += new System.EventHandler(this.dgv_HoaDon_SelectionChanged);
            // 
            // btn_qlsach
            // 
            this.btn_qlsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlsach.Location = new System.Drawing.Point(283, 144);
            this.btn_qlsach.Name = "btn_qlsach";
            this.btn_qlsach.Size = new System.Drawing.Size(175, 99);
            this.btn_qlsach.TabIndex = 83;
            this.btn_qlsach.Text = "QL Sách";
            this.btn_qlsach.UseVisualStyleBackColor = true;
            this.btn_qlsach.Click += new System.EventHandler(this.btn_qlsach_Click);
            // 
            // btn_bansach
            // 
            this.btn_bansach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bansach.Location = new System.Drawing.Point(26, 144);
            this.btn_bansach.Name = "btn_bansach";
            this.btn_bansach.Size = new System.Drawing.Size(175, 99);
            this.btn_bansach.TabIndex = 84;
            this.btn_bansach.Text = "Bán Sách";
            this.btn_bansach.UseVisualStyleBackColor = true;
            this.btn_bansach.Click += new System.EventHandler(this.btn_bansach_Click);
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2505, 1432);
            this.Controls.Add(this.btn_bansach);
            this.Controls.Add(this.btn_qlsach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "frm_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Sach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Sach_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_sach;
        private System.Windows.Forms.ComboBox cbb_danhmuc;
        private System.Windows.Forms.ComboBox cbb_tacgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_slkho;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Button btn_inhd;
        private System.Windows.Forms.Button btn_xoahd;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Button btn_qlsach;
        private System.Windows.Forms.Button btn_bansach;
        private System.Windows.Forms.TextBox txt_tongtienhd;
        private System.Windows.Forms.Button btn_tonghd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_slsachdh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_soluongsachdh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;

    }
}