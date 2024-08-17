namespace QL_BanSach
{
    partial class frmDirectoty
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
            this.labDH = new System.Windows.Forms.Label();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDM = new System.Windows.Forms.Button();
            this.btnTG = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labDH
            // 
            this.labDH.AutoSize = true;
            this.labDH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDH.Location = new System.Drawing.Point(312, 41);
            this.labDH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDH.Name = "labDH";
            this.labDH.Size = new System.Drawing.Size(156, 32);
            this.labDH.TabIndex = 0;
            this.labDH.Text = "Điều hướng";
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(184, 131);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(150, 67);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDM
            // 
            this.btnDM.Location = new System.Drawing.Point(184, 253);
            this.btnDM.Name = "btnDM";
            this.btnDM.Size = new System.Drawing.Size(150, 67);
            this.btnDM.TabIndex = 2;
            this.btnDM.Text = "Quản lý danh mục sách";
            this.btnDM.UseVisualStyleBackColor = true;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // btnTG
            // 
            this.btnTG.Location = new System.Drawing.Point(443, 253);
            this.btnTG.Name = "btnTG";
            this.btnTG.Size = new System.Drawing.Size(150, 67);
            this.btnTG.TabIndex = 3;
            this.btnTG.Text = "Quản lý tác giả";
            this.btnTG.UseVisualStyleBackColor = true;
            this.btnTG.Click += new System.EventHandler(this.btnTG_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(184, 387);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 67);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(443, 387);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(150, 67);
            this.btnTK.TabIndex = 5;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(443, 131);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(150, 67);
            this.btnBS.TabIndex = 6;
            this.btnBS.Text = "Quản lý bán sách";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(657, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 67);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDirectoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 563);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTG);
            this.Controls.Add(this.btnDM);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.labDH);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDirectoty";
            this.Text = "frmDirectoty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDH;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDM;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnLogout;
    }
}