namespace Bai4
{
    partial class frmCau2Bai3
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtTinh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(129, 36);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(159, 22);
            this.txtHo.TabIndex = 1;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập vào họ:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(129, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(159, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Location = new System.Drawing.Point(94, 115);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(157, 27);
            this.btnNoiChuoi.TabIndex = 2;
            this.btnNoiChuoi.Text = "Nối Chuỗi họ tên";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            this.btnNoiChuoi.Click += new System.EventHandler(this.btnNoiChuoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(112, 161);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(0, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập vào số n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(141, 235);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(159, 22);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtTinh
            // 
            this.txtTinh.Location = new System.Drawing.Point(94, 276);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(157, 27);
            this.txtTinh.TabIndex = 2;
            this.txtTinh.Text = "Tính giai thừa";
            this.txtTinh.UseVisualStyleBackColor = true;
            this.txtTinh.Click += new System.EventHandler(this.txtTinh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả:";
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Location = new System.Drawing.Point(112, 316);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(0, 16);
            this.txtkq.TabIndex = 0;
            // 
            // frmCau2Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.btnNoiChuoi);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmCau2Bai3";
            this.Text = "frmCau2Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button txtTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtkq;
    }
}