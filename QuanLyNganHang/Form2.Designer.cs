namespace QuanLyNganHang
{
    partial class frmCapNhap
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
            this.lblKyHanGui = new System.Windows.Forms.Label();
            this.cBxKyHanGui = new System.Windows.Forms.ComboBox();
            this.dtpNgayLapSo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rBtnGuiKoKyHan = new System.Windows.Forms.RadioButton();
            this.rBtnGuiCoKyHan = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxSoTienGui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxLaiSuatKoKyHan = new System.Windows.Forms.TextBox();
            this.lblLaiSuat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKyHanGui
            // 
            this.lblKyHanGui.AutoSize = true;
            this.lblKyHanGui.Location = new System.Drawing.Point(356, 385);
            this.lblKyHanGui.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblKyHanGui.Name = "lblKyHanGui";
            this.lblKyHanGui.Size = new System.Drawing.Size(95, 21);
            this.lblKyHanGui.TabIndex = 42;
            this.lblKyHanGui.Text = "Kỳ hạn gửi:";
            this.lblKyHanGui.Visible = false;
            // 
            // cBxKyHanGui
            // 
            this.cBxKyHanGui.FormattingEnabled = true;
            this.cBxKyHanGui.Location = new System.Drawing.Point(462, 381);
            this.cBxKyHanGui.Margin = new System.Windows.Forms.Padding(4);
            this.cBxKyHanGui.Name = "cBxKyHanGui";
            this.cBxKyHanGui.Size = new System.Drawing.Size(165, 29);
            this.cBxKyHanGui.TabIndex = 45;
            this.cBxKyHanGui.Visible = false;
            // 
            // dtpNgayLapSo
            // 
            this.dtpNgayLapSo.CustomFormat = "";
            this.dtpNgayLapSo.Location = new System.Drawing.Point(356, 302);
            this.dtpNgayLapSo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLapSo.Name = "dtpNgayLapSo";
            this.dtpNgayLapSo.Size = new System.Drawing.Size(272, 29);
            this.dtpNgayLapSo.TabIndex = 44;
            this.dtpNgayLapSo.Value = new System.DateTime(2022, 11, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ngày lập sổ";
            // 
            // rBtnGuiKoKyHan
            // 
            this.rBtnGuiKoKyHan.AutoSize = true;
            this.rBtnGuiKoKyHan.Location = new System.Drawing.Point(139, 448);
            this.rBtnGuiKoKyHan.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnGuiKoKyHan.Name = "rBtnGuiKoKyHan";
            this.rBtnGuiKoKyHan.Size = new System.Drawing.Size(161, 25);
            this.rBtnGuiKoKyHan.TabIndex = 41;
            this.rBtnGuiKoKyHan.TabStop = true;
            this.rBtnGuiKoKyHan.Text = "Gửi không kỳ hạn";
            this.rBtnGuiKoKyHan.UseVisualStyleBackColor = true;
            this.rBtnGuiKoKyHan.Click += new System.EventHandler(this.rBtnGuiKoKyHan_Click);
            // 
            // rBtnGuiCoKyHan
            // 
            this.rBtnGuiCoKyHan.AutoSize = true;
            this.rBtnGuiCoKyHan.Location = new System.Drawing.Point(139, 382);
            this.rBtnGuiCoKyHan.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnGuiCoKyHan.Name = "rBtnGuiCoKyHan";
            this.rBtnGuiCoKyHan.Size = new System.Drawing.Size(134, 25);
            this.rBtnGuiCoKyHan.TabIndex = 40;
            this.rBtnGuiCoKyHan.TabStop = true;
            this.rBtnGuiCoKyHan.Text = "Gửi có kỳ hạn";
            this.rBtnGuiCoKyHan.UseVisualStyleBackColor = true;
            this.rBtnGuiCoKyHan.Click += new System.EventHandler(this.rBtnCoKyHan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "VND";
            // 
            // txtBxCMND
            // 
            this.txtBxCMND.Location = new System.Drawing.Point(356, 164);
            this.txtBxCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxCMND.Name = "txtBxCMND";
            this.txtBxCMND.Size = new System.Drawing.Size(271, 29);
            this.txtBxCMND.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "CMND:";
            // 
            // txtBxSoTienGui
            // 
            this.txtBxSoTienGui.Location = new System.Drawing.Point(356, 232);
            this.txtBxSoTienGui.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSoTienGui.Name = "txtBxSoTienGui";
            this.txtBxSoTienGui.Size = new System.Drawing.Size(211, 29);
            this.txtBxSoTienGui.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Số tiền gửi:";
            // 
            // txtBxTenKhachHang
            // 
            this.txtBxTenKhachHang.Location = new System.Drawing.Point(356, 98);
            this.txtBxTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxTenKhachHang.Name = "txtBxTenKhachHang";
            this.txtBxTenKhachHang.Size = new System.Drawing.Size(271, 29);
            this.txtBxTenKhachHang.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtBxLaiSuatKoKyHan
            // 
            this.txtBxLaiSuatKoKyHan.Enabled = false;
            this.txtBxLaiSuatKoKyHan.Location = new System.Drawing.Point(438, 445);
            this.txtBxLaiSuatKoKyHan.Name = "txtBxLaiSuatKoKyHan";
            this.txtBxLaiSuatKoKyHan.Size = new System.Drawing.Size(42, 29);
            this.txtBxLaiSuatKoKyHan.TabIndex = 47;
            this.txtBxLaiSuatKoKyHan.Text = "1%";
            this.txtBxLaiSuatKoKyHan.Visible = false;
            // 
            // lblLaiSuat
            // 
            this.lblLaiSuat.AutoSize = true;
            this.lblLaiSuat.Enabled = false;
            this.lblLaiSuat.Location = new System.Drawing.Point(356, 448);
            this.lblLaiSuat.Name = "lblLaiSuat";
            this.lblLaiSuat.Size = new System.Drawing.Size(68, 21);
            this.lblLaiSuat.TabIndex = 46;
            this.lblLaiSuat.Text = "Lãi suất";
            this.lblLaiSuat.Visible = false;
            // 
            // frmCapNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 630);
            this.Controls.Add(this.txtBxLaiSuatKoKyHan);
            this.Controls.Add(this.lblLaiSuat);
            this.Controls.Add(this.lblKyHanGui);
            this.Controls.Add(this.cBxKyHanGui);
            this.Controls.Add(this.dtpNgayLapSo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rBtnGuiKoKyHan);
            this.Controls.Add(this.rBtnGuiCoKyHan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxSoTienGui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxTenKhachHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhap";
            this.Text = "Cập nhập thông tin";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKyHanGui;
        private ComboBox cBxKyHanGui;
        private DateTimePicker dtpNgayLapSo;
        private Label label6;
        private RadioButton rBtnGuiKoKyHan;
        private RadioButton rBtnGuiCoKyHan;
        private Label label8;
        private TextBox txtBxCMND;
        private Label label4;
        private TextBox txtBxSoTienGui;
        private Label label3;
        private TextBox txtBxTenKhachHang;
        private Label label1;
        private TextBox txtBxLaiSuatKoKyHan;
        private Label lblLaiSuat;
    }
}