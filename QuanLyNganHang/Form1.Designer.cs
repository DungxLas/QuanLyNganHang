namespace QuanLyNganHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtBxSoTienGui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rBtnGuiCoKyHan = new System.Windows.Forms.RadioButton();
            this.rBtnGuiKoKyHan = new System.Windows.Forms.RadioButton();
            this.lblKyHanGui = new System.Windows.Forms.Label();
            this.dtpNgayLapSo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cBxKyHanGui = new System.Windows.Forms.ComboBox();
            this.listViewDanhSachSo = new System.Windows.Forms.ListView();
            this.clTenKhachHang = new System.Windows.Forms.ColumnHeader();
            this.clCMND = new System.Windows.Forms.ColumnHeader();
            this.clSoTienGui = new System.Windows.Forms.ColumnHeader();
            this.clNgayLapSo = new System.Windows.Forms.ColumnHeader();
            this.clKyhanLaisuat = new System.Windows.Forms.ColumnHeader();
            this.lblLaiSuat = new System.Windows.Forms.Label();
            this.txtBxLaiSuatKoKyHan = new System.Windows.Forms.TextBox();
            this.clStt = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtBxTenKhachHang
            // 
            this.txtBxTenKhachHang.Location = new System.Drawing.Point(233, 34);
            this.txtBxTenKhachHang.Name = "txtBxTenKhachHang";
            this.txtBxTenKhachHang.Size = new System.Drawing.Size(323, 32);
            this.txtBxTenKhachHang.TabIndex = 1;
            // 
            // txtBxSoTienGui
            // 
            this.txtBxSoTienGui.Location = new System.Drawing.Point(233, 130);
            this.txtBxSoTienGui.Name = "txtBxSoTienGui";
            this.txtBxSoTienGui.Size = new System.Drawing.Size(323, 32);
            this.txtBxSoTienGui.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền gửi:";
            // 
            // txtBxCMND
            // 
            this.txtBxCMND.Location = new System.Drawing.Point(233, 81);
            this.txtBxCMND.Name = "txtBxCMND";
            this.txtBxCMND.Size = new System.Drawing.Size(323, 32);
            this.txtBxCMND.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMND:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "VND";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 331);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(180, 331);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(278, 331);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 31);
            this.button5.TabIndex = 25;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(484, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 31);
            this.button6.TabIndex = 24;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // rBtnGuiCoKyHan
            // 
            this.rBtnGuiCoKyHan.AutoSize = true;
            this.rBtnGuiCoKyHan.Location = new System.Drawing.Point(81, 237);
            this.rBtnGuiCoKyHan.Name = "rBtnGuiCoKyHan";
            this.rBtnGuiCoKyHan.Size = new System.Drawing.Size(143, 27);
            this.rBtnGuiCoKyHan.TabIndex = 14;
            this.rBtnGuiCoKyHan.TabStop = true;
            this.rBtnGuiCoKyHan.Text = "Gửi có kỳ hạn";
            this.rBtnGuiCoKyHan.UseVisualStyleBackColor = true;
            this.rBtnGuiCoKyHan.Click += new System.EventHandler(this.rBtnCoKyHan_Click);
            // 
            // rBtnGuiKoKyHan
            // 
            this.rBtnGuiKoKyHan.AutoSize = true;
            this.rBtnGuiKoKyHan.Location = new System.Drawing.Point(81, 284);
            this.rBtnGuiKoKyHan.Name = "rBtnGuiKoKyHan";
            this.rBtnGuiKoKyHan.Size = new System.Drawing.Size(174, 27);
            this.rBtnGuiKoKyHan.TabIndex = 15;
            this.rBtnGuiKoKyHan.TabStop = true;
            this.rBtnGuiKoKyHan.Text = "Gửi không kỳ hạn";
            this.rBtnGuiKoKyHan.UseVisualStyleBackColor = true;
            this.rBtnGuiKoKyHan.Click += new System.EventHandler(this.rBtnGuiKoKyHan_Click);
            // 
            // lblKyHanGui
            // 
            this.lblKyHanGui.AutoSize = true;
            this.lblKyHanGui.Location = new System.Drawing.Point(233, 239);
            this.lblKyHanGui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKyHanGui.Name = "lblKyHanGui";
            this.lblKyHanGui.Size = new System.Drawing.Size(106, 23);
            this.lblKyHanGui.TabIndex = 17;
            this.lblKyHanGui.Text = "Kỳ hạn gửi:";
            this.lblKyHanGui.Visible = false;
            // 
            // dtpNgayLapSo
            // 
            this.dtpNgayLapSo.CustomFormat = "";
            this.dtpNgayLapSo.Location = new System.Drawing.Point(233, 180);
            this.dtpNgayLapSo.Name = "dtpNgayLapSo";
            this.dtpNgayLapSo.Size = new System.Drawing.Size(323, 32);
            this.dtpNgayLapSo.TabIndex = 31;
            this.dtpNgayLapSo.Value = new System.DateTime(2022, 11, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày lập sổ";
            // 
            // cBxKyHanGui
            // 
            this.cBxKyHanGui.FormattingEnabled = true;
            this.cBxKyHanGui.Location = new System.Drawing.Point(347, 236);
            this.cBxKyHanGui.Name = "cBxKyHanGui";
            this.cBxKyHanGui.Size = new System.Drawing.Size(209, 31);
            this.cBxKyHanGui.TabIndex = 32;
            this.cBxKyHanGui.Visible = false;
            // 
            // listViewDanhSachSo
            // 
            this.listViewDanhSachSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDanhSachSo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewDanhSachSo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStt,
            this.clTenKhachHang,
            this.clCMND,
            this.clSoTienGui,
            this.clNgayLapSo,
            this.clKyhanLaisuat});
            this.listViewDanhSachSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewDanhSachSo.FullRowSelect = true;
            this.listViewDanhSachSo.GridLines = true;
            this.listViewDanhSachSo.Location = new System.Drawing.Point(46, 399);
            this.listViewDanhSachSo.Name = "listViewDanhSachSo";
            this.listViewDanhSachSo.Size = new System.Drawing.Size(623, 278);
            this.listViewDanhSachSo.TabIndex = 33;
            this.listViewDanhSachSo.TileSize = new System.Drawing.Size(1, 1);
            this.listViewDanhSachSo.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSachSo.View = System.Windows.Forms.View.Details;
            // 
            // clTenKhachHang
            // 
            this.clTenKhachHang.Text = "Tên Khách Hàng";
            this.clTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenKhachHang.Width = 120;
            // 
            // clCMND
            // 
            this.clCMND.Text = "CMND";
            this.clCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clCMND.Width = 120;
            // 
            // clSoTienGui
            // 
            this.clSoTienGui.Text = "Số tiền gửi ban đầu";
            this.clSoTienGui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSoTienGui.Width = 120;
            // 
            // clNgayLapSo
            // 
            this.clNgayLapSo.Text = "Ngày lập sổ";
            this.clNgayLapSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNgayLapSo.Width = 120;
            // 
            // clKyhanLaisuat
            // 
            this.clKyhanLaisuat.Text = "Kỳ hạn / Lãi suất";
            this.clKyhanLaisuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clKyhanLaisuat.Width = 120;
            // 
            // lblLaiSuat
            // 
            this.lblLaiSuat.AutoSize = true;
            this.lblLaiSuat.Location = new System.Drawing.Point(278, 286);
            this.lblLaiSuat.Name = "lblLaiSuat";
            this.lblLaiSuat.Size = new System.Drawing.Size(76, 23);
            this.lblLaiSuat.TabIndex = 34;
            this.lblLaiSuat.Text = "Lãi suất";
            this.lblLaiSuat.Visible = false;
            // 
            // txtBxLaiSuatKoKyHan
            // 
            this.txtBxLaiSuatKoKyHan.Enabled = false;
            this.txtBxLaiSuatKoKyHan.Location = new System.Drawing.Point(360, 283);
            this.txtBxLaiSuatKoKyHan.Name = "txtBxLaiSuatKoKyHan";
            this.txtBxLaiSuatKoKyHan.Size = new System.Drawing.Size(42, 32);
            this.txtBxLaiSuatKoKyHan.TabIndex = 35;
            this.txtBxLaiSuatKoKyHan.Text = "1%";
            this.txtBxLaiSuatKoKyHan.Visible = false;
            // 
            // clStt
            // 
            this.clStt.Text = "STT";
            this.clStt.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 720);
            this.Controls.Add(this.txtBxLaiSuatKoKyHan);
            this.Controls.Add(this.lblLaiSuat);
            this.Controls.Add(this.listViewDanhSachSo);
            this.Controls.Add(this.lblKyHanGui);
            this.Controls.Add(this.cBxKyHanGui);
            this.Controls.Add(this.dtpNgayLapSo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rBtnGuiKoKyHan);
            this.Controls.Add(this.rBtnGuiCoKyHan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxSoTienGui);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxTenKhachHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Quản lý ngân Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBxTenKhachHang;
        private TextBox txtBxSoTienGui;
        private Label label3;
        private TextBox txtBxCMND;
        private Label label4;
        private Label label8;
        private Button btnThem;
        private Button btnXoa;
        private Button button3;
        private Button btnSua;
        private Button button5;
        private Button button6;
        private RadioButton rBtnGuiCoKyHan;
        private RadioButton rBtnGuiKoKyHan;
        private Label lblKyHanGui;
        private DateTimePicker dtpNgayLapSo;
        private Label label6;
        private ComboBox cBxKyHanGui;
        private ListView listViewDanhSachSo;
        private ColumnHeader clTenKhachHang;
        private ColumnHeader clCMND;
        private ColumnHeader clSoTienGui;
        private ColumnHeader clNgayLapSo;
        private ColumnHeader clKyhanLaisuat;
        private Label lblLaiSuat;
        private TextBox txtBxLaiSuatKoKyHan;
        private ColumnHeader clStt;
    }
}