namespace Stanford_LapTrinhWindowsFormCS
{
    partial class frmSuDungVongLap
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.ListBox();
            this.rbtnWhile = new System.Windows.Forms.RadioButton();
            this.rbtnDoWhile = new System.Windows.Forms.RadioButton();
            this.rbtnFor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin:";
            // 
            // lbThongTin
            // 
            this.lbThongTin.FormattingEnabled = true;
            this.lbThongTin.ItemHeight = 24;
            this.lbThongTin.Location = new System.Drawing.Point(41, 87);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(601, 268);
            this.lbThongTin.TabIndex = 1;
            // 
            // rbtnWhile
            // 
            this.rbtnWhile.AutoSize = true;
            this.rbtnWhile.Location = new System.Drawing.Point(41, 379);
            this.rbtnWhile.Name = "rbtnWhile";
            this.rbtnWhile.Size = new System.Drawing.Size(87, 29);
            this.rbtnWhile.TabIndex = 2;
            this.rbtnWhile.TabStop = true;
            this.rbtnWhile.Text = "While";
            this.rbtnWhile.UseVisualStyleBackColor = true;
            this.rbtnWhile.CheckedChanged += new System.EventHandler(this.rbtnWhile_CheckedChanged);
            // 
            // rbtnDoWhile
            // 
            this.rbtnDoWhile.AutoSize = true;
            this.rbtnDoWhile.Location = new System.Drawing.Point(209, 379);
            this.rbtnDoWhile.Name = "rbtnDoWhile";
            this.rbtnDoWhile.Size = new System.Drawing.Size(117, 29);
            this.rbtnDoWhile.TabIndex = 3;
            this.rbtnDoWhile.TabStop = true;
            this.rbtnDoWhile.Text = "Do While";
            this.rbtnDoWhile.UseVisualStyleBackColor = true;
            this.rbtnDoWhile.CheckedChanged += new System.EventHandler(this.rbtnDoWhile_CheckedChanged);
            // 
            // rbtnFor
            // 
            this.rbtnFor.AutoSize = true;
            this.rbtnFor.Location = new System.Drawing.Point(388, 379);
            this.rbtnFor.Name = "rbtnFor";
            this.rbtnFor.Size = new System.Drawing.Size(66, 29);
            this.rbtnFor.TabIndex = 4;
            this.rbtnFor.TabStop = true;
            this.rbtnFor.Text = "For";
            this.rbtnFor.UseVisualStyleBackColor = true;
            this.rbtnFor.CheckedChanged += new System.EventHandler(this.rbtnFor_CheckedChanged);
            // 
            // frmSuDungVongLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.rbtnFor);
            this.Controls.Add(this.rbtnDoWhile);
            this.Controls.Add(this.rbtnWhile);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.label1);
            this.Name = "frmSuDungVongLap";
            this.Text = "frmSuDungVongLap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbThongTin;
        private System.Windows.Forms.RadioButton rbtnWhile;
        private System.Windows.Forms.RadioButton rbtnDoWhile;
        private System.Windows.Forms.RadioButton rbtnFor;
    }
}