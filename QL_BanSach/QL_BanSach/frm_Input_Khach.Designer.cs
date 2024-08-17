namespace QL_BanSach
{
    partial class frm_Input_Khach
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
            this.rdo_khachcu = new System.Windows.Forms.RadioButton();
            this.rdo_khachmoi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sdt_kt = new System.Windows.Forms.TextBox();
            this.btn_kiemtra = new System.Windows.Forms.Button();
            this.lb_tb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.lb_tb2 = new System.Windows.Forms.Label();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_khachcu
            // 
            this.rdo_khachcu.AutoSize = true;
            this.rdo_khachcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_khachcu.Location = new System.Drawing.Point(127, 9);
            this.rdo_khachcu.Name = "rdo_khachcu";
            this.rdo_khachcu.Size = new System.Drawing.Size(197, 41);
            this.rdo_khachcu.TabIndex = 0;
            this.rdo_khachcu.TabStop = true;
            this.rdo_khachcu.Text = "Khách Củ";
            this.rdo_khachcu.UseVisualStyleBackColor = true;
            this.rdo_khachcu.CheckedChanged += new System.EventHandler(this.rdo_khachcu_CheckedChanged);
            // 
            // rdo_khachmoi
            // 
            this.rdo_khachmoi.AutoSize = true;
            this.rdo_khachmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_khachmoi.Location = new System.Drawing.Point(127, 260);
            this.rdo_khachmoi.Name = "rdo_khachmoi";
            this.rdo_khachmoi.Size = new System.Drawing.Size(208, 41);
            this.rdo_khachmoi.TabIndex = 1;
            this.rdo_khachmoi.TabStop = true;
            this.rdo_khachmoi.Text = "Khách Mới";
            this.rdo_khachmoi.UseVisualStyleBackColor = true;
            this.rdo_khachmoi.CheckedChanged += new System.EventHandler(this.rdo_khachmoi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tb);
            this.groupBox1.Controls.Add(this.btn_kiemtra);
            this.groupBox1.Controls.Add(this.txt_sdt_kt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(225, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_tb2);
            this.groupBox2.Controls.Add(this.btn_dangky);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_dc);
            this.groupBox2.Controls.Add(this.txt_tenkh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(225, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 388);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số điện thoại khách";
            // 
            // txt_sdt_kt
            // 
            this.txt_sdt_kt.Location = new System.Drawing.Point(37, 107);
            this.txt_sdt_kt.Multiline = true;
            this.txt_sdt_kt.Name = "txt_sdt_kt";
            this.txt_sdt_kt.Size = new System.Drawing.Size(396, 51);
            this.txt_sdt_kt.TabIndex = 1;
            // 
            // btn_kiemtra
            // 
            this.btn_kiemtra.Location = new System.Drawing.Point(468, 107);
            this.btn_kiemtra.Name = "btn_kiemtra";
            this.btn_kiemtra.Size = new System.Drawing.Size(193, 51);
            this.btn_kiemtra.TabIndex = 2;
            this.btn_kiemtra.Text = "Kiểm Tra";
            this.btn_kiemtra.UseVisualStyleBackColor = true;
            this.btn_kiemtra.Click += new System.EventHandler(this.btn_kiemtra_Click);
            // 
            // lb_tb
            // 
            this.lb_tb.AutoSize = true;
            this.lb_tb.ForeColor = System.Drawing.Color.Red;
            this.lb_tb.Location = new System.Drawing.Point(31, 161);
            this.lb_tb.Name = "lb_tb";
            this.lb_tb.Size = new System.Drawing.Size(0, 31);
            this.lb_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(229, 37);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(540, 51);
            this.txt_tenkh.TabIndex = 4;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(229, 104);
            this.txt_dc.Multiline = true;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(540, 51);
            this.txt_dc.TabIndex = 8;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(229, 168);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(540, 51);
            this.txt_sdt.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(229, 232);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(540, 51);
            this.txt_email.TabIndex = 10;
            // 
            // btn_dangky
            // 
            this.btn_dangky.Location = new System.Drawing.Point(332, 331);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(193, 51);
            this.btn_dangky.TabIndex = 4;
            this.btn_dangky.Text = "Đăng Ký";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // lb_tb2
            // 
            this.lb_tb2.AutoSize = true;
            this.lb_tb2.ForeColor = System.Drawing.Color.Red;
            this.lb_tb2.Location = new System.Drawing.Point(237, 302);
            this.lb_tb2.Name = "lb_tb2";
            this.lb_tb2.Size = new System.Drawing.Size(0, 31);
            this.lb_tb2.TabIndex = 4;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.Location = new System.Drawing.Point(510, 692);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(283, 74);
            this.btn_xacnhan.TabIndex = 11;
            this.btn_xacnhan.Text = "Xác Nhận";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // frm_Input_Khach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1228, 1047);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdo_khachmoi);
            this.Controls.Add(this.rdo_khachcu);
            this.Name = "frm_Input_Khach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frm_Input_Khach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_khachcu;
        private System.Windows.Forms.RadioButton rdo_khachmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_tb;
        private System.Windows.Forms.Button btn_kiemtra;
        private System.Windows.Forms.TextBox txt_sdt_kt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tb2;
        private System.Windows.Forms.Button btn_xacnhan;
    }
}