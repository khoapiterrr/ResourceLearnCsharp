namespace Stanford_BaiKiemTra
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.txbInput2 = new System.Windows.Forms.TextBox();
            this.txbInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbOutput);
            this.groupBox1.Controls.Add(this.txbInput2);
            this.groupBox1.Controls.Add(this.txbInput1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính tổng lớn";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(143, 103);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(91, 42);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "Cộng";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả:";
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(143, 165);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(351, 23);
            this.txbOutput.TabIndex = 3;
            this.txbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbInput2
            // 
            this.txbInput2.Location = new System.Drawing.Point(143, 72);
            this.txbInput2.Name = "txbInput2";
            this.txbInput2.Size = new System.Drawing.Size(351, 23);
            this.txbInput2.TabIndex = 2;
            this.txbInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbInput1
            // 
            this.txbInput1.Location = new System.Drawing.Point(143, 32);
            this.txbInput1.Name = "txbInput1";
            this.txbInput1.Size = new System.Drawing.Size(351, 23);
            this.txbInput1.TabIndex = 1;
            this.txbInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số thứ 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thứ 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 256);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.TextBox txbInput2;
        private System.Windows.Forms.TextBox txbInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}

