namespace BaiTapLon
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btdangkymoi = new System.Windows.Forms.Button();
            this.cbhienthimk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbusers = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbhienthimk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btdangnhap);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbusers);
            this.panel1.Controls.Add(this.lbpass);
            this.panel1.Controls.Add(this.lbuser);
            this.panel1.Location = new System.Drawing.Point(30, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 770);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btexit);
            this.panel2.Controls.Add(this.btdangkymoi);
            this.panel2.Location = new System.Drawing.Point(-1, 649);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 120);
            this.panel2.TabIndex = 1;
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.Red;
            this.btexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.SystemColors.Control;
            this.btexit.Location = new System.Drawing.Point(220, 71);
            this.btexit.Margin = new System.Windows.Forms.Padding(4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(148, 43);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "EXIT";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdangkymoi
            // 
            this.btdangkymoi.BackColor = System.Drawing.Color.Red;
            this.btdangkymoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangkymoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btdangkymoi.Location = new System.Drawing.Point(119, 4);
            this.btdangkymoi.Margin = new System.Windows.Forms.Padding(4);
            this.btdangkymoi.Name = "btdangkymoi";
            this.btdangkymoi.Size = new System.Drawing.Size(358, 62);
            this.btdangkymoi.TabIndex = 0;
            this.btdangkymoi.Text = "Tạo tài khoản";
            this.btdangkymoi.UseVisualStyleBackColor = false;
            this.btdangkymoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhienthimk
            // 
            this.cbhienthimk.AutoSize = true;
            this.cbhienthimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhienthimk.Location = new System.Drawing.Point(199, 508);
            this.cbhienthimk.Margin = new System.Windows.Forms.Padding(4);
            this.cbhienthimk.Name = "cbhienthimk";
            this.cbhienthimk.Size = new System.Drawing.Size(205, 29);
            this.cbhienthimk.TabIndex = 8;
            this.cbhienthimk.Text = "Hiển thị mật khẩu";
            this.cbhienthimk.UseVisualStyleBackColor = true;
            this.cbhienthimk.CheckedChanged += new System.EventHandler(this.cbhienthimk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btdangnhap.Location = new System.Drawing.Point(119, 563);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(358, 55);
            this.btdangnhap.TabIndex = 4;
            this.btdangnhap.Text = "Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(182, 426);
            this.tbpass.Margin = new System.Windows.Forms.Padding(4);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '✱';
            this.tbpass.Size = new System.Drawing.Size(333, 37);
            this.tbpass.TabIndex = 3;
            // 
            // tbusers
            // 
            this.tbusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusers.Location = new System.Drawing.Point(182, 317);
            this.tbusers.Margin = new System.Windows.Forms.Padding(4);
            this.tbusers.Name = "tbusers";
            this.tbusers.Size = new System.Drawing.Size(333, 37);
            this.tbusers.TabIndex = 2;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(19, 430);
            this.lbpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(146, 32);
            this.lbpass.TabIndex = 1;
            this.lbpass.Text = "Password:";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(19, 320);
            this.lbuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(152, 32);
            this.lbuser.TabIndex = 0;
            this.lbuser.Text = "Username:";
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(631, 799);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DANGNHAP";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbusers;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btdangkymoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbhienthimk;
    }
}

