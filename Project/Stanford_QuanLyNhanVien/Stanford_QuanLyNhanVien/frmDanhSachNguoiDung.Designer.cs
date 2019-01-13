namespace Stanford_QuanLyNhanVien
{
    partial class frmDanhSachNguoiDung
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
            this.ucAction1 = new Stanford_QuanLyNhanVien.Base.ucAction();
            this.SuspendLayout();
            // 
            // ucAction1
            // 
            this.ucAction1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucAction1.Location = new System.Drawing.Point(0, 546);
            this.ucAction1.Name = "ucAction1";
            this.ucAction1.Size = new System.Drawing.Size(1126, 86);
            this.ucAction1.TabIndex = 0;
            // 
            // frmDanhSachNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 632);
            this.Controls.Add(this.ucAction1);
            this.Name = "frmDanhSachNguoiDung";
            this.Text = "frmDanhSachNguoiDung";
            this.Load += new System.EventHandler(this.frmDanhSachNguoiDung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Base.ucAction ucAction1;
    }
}