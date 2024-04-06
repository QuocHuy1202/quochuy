namespace WindowsFormsApp2
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dangki = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.quenmatkhau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taikhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(251, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 79);
            this.panel1.TabIndex = 10;
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(215, 33);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(280, 22);
            this.taikhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.matkhau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(251, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 79);
            this.panel3.TabIndex = 11;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(215, 32);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(280, 22);
            this.matkhau.TabIndex = 2;
            this.matkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // dangki
            // 
            this.dangki.Location = new System.Drawing.Point(261, 354);
            this.dangki.Name = "dangki";
            this.dangki.Size = new System.Drawing.Size(97, 51);
            this.dangki.TabIndex = 15;
            this.dangki.Text = "Đăng kí";
            this.dangki.UseVisualStyleBackColor = true;
            this.dangki.Click += new System.EventHandler(this.dangki_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(649, 354);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 51);
            this.exit.TabIndex = 14;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(70, 354);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(97, 51);
            this.dangnhap.TabIndex = 13;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.Location = new System.Drawing.Point(466, 354);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(97, 51);
            this.quenmatkhau.TabIndex = 12;
            this.quenmatkhau.Text = "Quên mật khẩu";
            this.quenmatkhau.UseVisualStyleBackColor = true;
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(25, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dangki);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.quenmatkhau);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dangki;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button quenmatkhau;
    }
}

