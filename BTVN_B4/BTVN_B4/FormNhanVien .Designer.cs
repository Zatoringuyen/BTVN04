namespace BTVN_B4
{
    partial class FormNhanVien
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
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtMsnv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(349, 212);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(85, 30);
            this.btnBoqua.TabIndex = 9;
            this.btnBoqua.Text = "Bo qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(180, 212);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(85, 30);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Dong y";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(250, 115);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(216, 22);
            this.txtTen.TabIndex = 6;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(250, 154);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(216, 22);
            this.txtLuong.TabIndex = 7;
            // 
            // txtMsnv
            // 
            this.txtMsnv.Location = new System.Drawing.Point(250, 74);
            this.txtMsnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMsnv.Name = "txtMsnv";
            this.txtMsnv.Size = new System.Drawing.Size(216, 22);
            this.txtMsnv.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Luong Can Ban";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten Nhan Vien";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "MSNV:";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 287);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMsnv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtMsnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}