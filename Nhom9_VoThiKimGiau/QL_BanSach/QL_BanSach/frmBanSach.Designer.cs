namespace QL_BanSach
{
    partial class frmBanSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_inf_book = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv_DonHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tang1 = new System.Windows.Forms.Button();
            this.btn_giam1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.rdo_timtg = new System.Windows.Forms.RadioButton();
            this.rdo_timten = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_bansach = new System.Windows.Forms.Button();
            this.btn_qlsach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inf_book)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_inf_book
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_inf_book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inf_book.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inf_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inf_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inf_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.SLKho});
            this.dgv_inf_book.Location = new System.Drawing.Point(24, 251);
            this.dgv_inf_book.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_inf_book.Name = "dgv_inf_book";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inf_book.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_inf_book.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_inf_book.RowTemplate.Height = 33;
            this.dgv_inf_book.Size = new System.Drawing.Size(505, 263);
            this.dgv_inf_book.TabIndex = 0;
            this.dgv_inf_book.SelectionChanged += new System.EventHandler(this.dgv_inf_book_SelectionChanged);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 70;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 230;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // SLKho
            // 
            this.SLKho.DataPropertyName = "SLKho";
            this.SLKho.HeaderText = "Số Lượng Kho";
            this.SLKho.Name = "SLKho";
            // 
            // lv_DonHang
            // 
            this.lv_DonHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_DonHang.Location = new System.Drawing.Point(537, 127);
            this.lv_DonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_DonHang.Name = "lv_DonHang";
            this.lv_DonHang.Size = new System.Drawing.Size(446, 265);
            this.lv_DonHang.TabIndex = 1;
            this.lv_DonHang.UseCompatibleStateImageBehavior = false;
            this.lv_DonHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành Tiền";
            // 
            // btn_tang1
            // 
            this.btn_tang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tang1.Location = new System.Drawing.Point(537, 411);
            this.btn_tang1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tang1.Name = "btn_tang1";
            this.btn_tang1.Size = new System.Drawing.Size(88, 30);
            this.btn_tang1.TabIndex = 3;
            this.btn_tang1.Text = "+1";
            this.btn_tang1.UseVisualStyleBackColor = true;
            this.btn_tang1.Click += new System.EventHandler(this.btn_tang1_Click);
            // 
            // btn_giam1
            // 
            this.btn_giam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giam1.Location = new System.Drawing.Point(644, 411);
            this.btn_giam1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_giam1.Name = "btn_giam1";
            this.btn_giam1.Size = new System.Drawing.Size(88, 30);
            this.btn_giam1.TabIndex = 4;
            this.btn_giam1.Text = "-1";
            this.btn_giam1.UseVisualStyleBackColor = true;
            this.btn_giam1.Click += new System.EventHandler(this.btn_giam1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(626, 453);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(107, 23);
            this.txt_soluong.TabIndex = 6;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(537, 487);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(88, 30);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dat
            // 
            this.btn_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dat.Location = new System.Drawing.Point(644, 487);
            this.btn_dat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dat.Name = "btn_dat";
            this.btn_dat.Size = new System.Drawing.Size(88, 30);
            this.btn_dat.TabIndex = 8;
            this.btn_dat.Text = "Đặt";
            this.btn_dat.UseVisualStyleBackColor = true;
            this.btn_dat.Click += new System.EventHandler(this.btn_dat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thành Tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(862, 395);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(120, 29);
            this.txt_tongtien.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Controls.Add(this.rdo_timtg);
            this.groupBox1.Controls.Add(this.rdo_timten);
            this.groupBox1.Location = new System.Drawing.Point(24, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(450, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(336, 36);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(88, 30);
            this.btn_load.TabIndex = 13;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(234, 36);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(88, 30);
            this.btn_tim.TabIndex = 12;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(26, 39);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tim.Multiline = true;
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(201, 29);
            this.txt_tim.TabIndex = 12;
            // 
            // rdo_timtg
            // 
            this.rdo_timtg.AutoSize = true;
            this.rdo_timtg.Location = new System.Drawing.Point(126, 16);
            this.rdo_timtg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_timtg.Name = "rdo_timtg";
            this.rdo_timtg.Size = new System.Drawing.Size(91, 17);
            this.rdo_timtg.TabIndex = 1;
            this.rdo_timtg.TabStop = true;
            this.rdo_timtg.Text = "Theo Tác Giả";
            this.rdo_timtg.UseVisualStyleBackColor = true;
            // 
            // rdo_timten
            // 
            this.rdo_timten.AutoSize = true;
            this.rdo_timten.Location = new System.Drawing.Point(26, 16);
            this.rdo_timten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_timten.Name = "rdo_timten";
            this.rdo_timten.Size = new System.Drawing.Size(72, 17);
            this.rdo_timten.TabIndex = 0;
            this.rdo_timten.TabStop = true;
            this.rdo_timten.Text = "Theo Tên";
            this.rdo_timten.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(778, 453);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "IN HÓA ĐƠN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_bansach
            // 
            this.btn_bansach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bansach.Location = new System.Drawing.Point(24, 94);
            this.btn_bansach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bansach.Name = "btn_bansach";
            this.btn_bansach.Size = new System.Drawing.Size(88, 51);
            this.btn_bansach.TabIndex = 13;
            this.btn_bansach.Text = "Bán Sách";
            this.btn_bansach.UseVisualStyleBackColor = true;
            this.btn_bansach.Click += new System.EventHandler(this.btn_bansach_Click);
            // 
            // btn_qlsach
            // 
            this.btn_qlsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlsach.Location = new System.Drawing.Point(137, 94);
            this.btn_qlsach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_qlsach.Name = "btn_qlsach";
            this.btn_qlsach.Size = new System.Drawing.Size(88, 51);
            this.btn_qlsach.TabIndex = 14;
            this.btn_qlsach.Text = "QL Sách";
            this.btn_qlsach.UseVisualStyleBackColor = true;
            this.btn_qlsach.Click += new System.EventHandler(this.btn_qlsach_Click);
            // 
            // frmBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 575);
            this.Controls.Add(this.btn_qlsach);
            this.Controls.Add(this.btn_bansach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giam1);
            this.Controls.Add(this.btn_tang1);
            this.Controls.Add(this.lv_DonHang);
            this.Controls.Add(this.dgv_inf_book);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBanSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmBanSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBanSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inf_book)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_inf_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLKho;
        private System.Windows.Forms.ListView lv_DonHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_tang1;
        private System.Windows.Forms.Button btn_giam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.RadioButton rdo_timtg;
        private System.Windows.Forms.RadioButton rdo_timten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_bansach;
        private System.Windows.Forms.Button btn_qlsach;
    }
}