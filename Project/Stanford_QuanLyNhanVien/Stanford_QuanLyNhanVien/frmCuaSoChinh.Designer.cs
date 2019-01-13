namespace Stanford_QuanLyNhanVien
{
    partial class frmCuaSoChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuNghiepVu,
            this.menuBaoCao,
            this.menuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNguoiDung,
            this.menuItemDangNhap,
            this.menuItemDangXuat,
            this.menuItemThoatChuongTrinh});
            this.menuHeThong.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.settings_16;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(140, 34);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuItemNguoiDung
            // 
            this.menuItemNguoiDung.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.user;
            this.menuItemNguoiDung.Name = "menuItemNguoiDung";
            this.menuItemNguoiDung.Size = new System.Drawing.Size(288, 34);
            this.menuItemNguoiDung.Text = "Người dùng";
            this.menuItemNguoiDung.Click += new System.EventHandler(this.menuItemNguoiDung_Click);
            // 
            // menuItemDangNhap
            // 
            this.menuItemDangNhap.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.icon_login_16x16;
            this.menuItemDangNhap.Name = "menuItemDangNhap";
            this.menuItemDangNhap.Size = new System.Drawing.Size(283, 34);
            this.menuItemDangNhap.Text = "Đăng nhập";
            this.menuItemDangNhap.Click += new System.EventHandler(this.menuItemDangNhap_Click);
            // 
            // menuItemDangXuat
            // 
            this.menuItemDangXuat.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.logout;
            this.menuItemDangXuat.Name = "menuItemDangXuat";
            this.menuItemDangXuat.Size = new System.Drawing.Size(283, 34);
            this.menuItemDangXuat.Text = "Đăng xuất";
            this.menuItemDangXuat.Click += new System.EventHandler(this.menuItemDangXuat_Click);
            // 
            // menuItemThoatChuongTrinh
            // 
            this.menuItemThoatChuongTrinh.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.cancel;
            this.menuItemThoatChuongTrinh.Name = "menuItemThoatChuongTrinh";
            this.menuItemThoatChuongTrinh.Size = new System.Drawing.Size(283, 34);
            this.menuItemThoatChuongTrinh.Text = "Thoát chương trình";
            // 
            // menuNghiepVu
            // 
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNhanVien,
            this.menuItemPhongBan,
            this.menuItemChucVu,
            this.menuItemKhachHang});
            this.menuNghiepVu.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.Group_3;
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(149, 34);
            this.menuNghiepVu.Text = "Nghiệp vụ";
            // 
            // menuItemNhanVien
            // 
            this.menuItemNhanVien.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.Group_3;
            this.menuItemNhanVien.Name = "menuItemNhanVien";
            this.menuItemNhanVien.Size = new System.Drawing.Size(288, 34);
            this.menuItemNhanVien.Text = "Nhân viên";
            this.menuItemNhanVien.Click += new System.EventHandler(this.menuItemNhanVien_Click);
            // 
            // menuItemPhongBan
            // 
            this.menuItemPhongBan.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.List_BulletsHS;
            this.menuItemPhongBan.Name = "menuItemPhongBan";
            this.menuItemPhongBan.Size = new System.Drawing.Size(288, 34);
            this.menuItemPhongBan.Text = "Phòng ban";
            // 
            // menuItemChucVu
            // 
            this.menuItemChucVu.Name = "menuItemChucVu";
            this.menuItemChucVu.Size = new System.Drawing.Size(288, 34);
            this.menuItemChucVu.Text = "Chức vụ";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.Bar_Chart_3;
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(127, 34);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHuongDan,
            this.menuItemTacGia});
            this.menuTroGiup.Image = global::Stanford_QuanLyNhanVien.Properties.Resources.Help;
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(129, 34);
            this.menuTroGiup.Text = "Trợ giúp";
            // 
            // menuItemHuongDan
            // 
            this.menuItemHuongDan.Name = "menuItemHuongDan";
            this.menuItemHuongDan.Size = new System.Drawing.Size(209, 34);
            this.menuItemHuongDan.Text = "Hướng dẫn";
            // 
            // menuItemTacGia
            // 
            this.menuItemTacGia.Name = "menuItemTacGia";
            this.menuItemTacGia.Size = new System.Drawing.Size(209, 34);
            this.menuItemTacGia.Text = "Tác giả";
            // 
            // menuItemKhachHang
            // 
            this.menuItemKhachHang.Name = "menuItemKhachHang";
            this.menuItemKhachHang.Size = new System.Drawing.Size(288, 34);
            this.menuItemKhachHang.Text = "Khách hàng";
            this.menuItemKhachHang.Click += new System.EventHandler(this.menuItemKhachHang_Click);
            // 
            // frmCuaSoChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 654);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCuaSoChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuaSoChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuItemNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuItemThoatChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuItemPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuItemChucVu;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuItemHuongDan;
        private System.Windows.Forms.ToolStripMenuItem menuItemTacGia;
        private System.Windows.Forms.ToolStripMenuItem menuItemKhachHang;
    }
}