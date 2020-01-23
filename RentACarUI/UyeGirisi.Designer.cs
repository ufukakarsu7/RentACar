namespace RentACarUI
{
    partial class UyeGirisi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_email = new ns1.BunifuMaterialTextbox();
            this.txt_sifre = new ns1.BunifuMaterialTextbox();
            this.btn_login = new ns1.BunifuFlatButton();
            this.lbl_sifremiunuttum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.HintForeColor = System.Drawing.Color.Empty;
            this.txt_email.HintText = "";
            this.txt_email.isPassword = false;
            this.txt_email.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txt_email.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_email.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_email.LineThickness = 3;
            this.txt_email.Location = new System.Drawing.Point(240, 214);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(266, 44);
            this.txt_email.TabIndex = 22;
            this.txt_email.Text = "hakan.alakus@gmail.com";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sifre.HintText = "";
            this.txt_sifre.isPassword = false;
            this.txt_sifre.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sifre.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre.LineThickness = 3;
            this.txt_sifre.Location = new System.Drawing.Point(240, 275);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(266, 44);
            this.txt_sifre.TabIndex = 23;
            this.txt_sifre.Text = "asdfgh";
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.Silver;
            this.btn_login.BackColor = System.Drawing.Color.Silver;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 7;
            this.btn_login.ButtonText = "Giriş Yap";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(300, 344);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.Silver;
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(144, 28);
            this.btn_login.TabIndex = 24;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.Black;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // lbl_sifremiunuttum
            // 
            this.lbl_sifremiunuttum.AutoSize = true;
            this.lbl_sifremiunuttum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifremiunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifremiunuttum.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_sifremiunuttum.Location = new System.Drawing.Point(319, 419);
            this.lbl_sifremiunuttum.Name = "lbl_sifremiunuttum";
            this.lbl_sifremiunuttum.Size = new System.Drawing.Size(107, 16);
            this.lbl_sifremiunuttum.TabIndex = 26;
            this.lbl_sifremiunuttum.Text = "Şifremi Unuttum?";
            this.lbl_sifremiunuttum.MouseEnter += new System.EventHandler(this.lbl_sifremiunuttum_MouseEnter);
            this.lbl_sifremiunuttum.MouseLeave += new System.EventHandler(this.lbl_sifremiunuttum_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RentACarUI.Properties.Resources.AAA_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(272, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // UyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._2175404;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_sifremiunuttum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_email);
            this.Name = "UyeGirisi";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.UyeGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuMaterialTextbox txt_email;
        private ns1.BunifuMaterialTextbox txt_sifre;
        private ns1.BunifuFlatButton btn_login;
        private System.Windows.Forms.Label lbl_sifremiunuttum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
