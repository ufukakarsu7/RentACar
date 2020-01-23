namespace RentACarUI
{
    partial class KayitOl
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
            this.txt_sifre1 = new ns1.BunifuMaterialTextbox();
            this.txt_sifre2 = new ns1.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kayit = new ns1.BunifuFlatButton();
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
            this.txt_email.Location = new System.Drawing.Point(258, 220);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 32);
            this.txt_email.TabIndex = 13;
            this.txt_email.Text = "Email";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_sifre1
            // 
            this.txt_sifre1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sifre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sifre1.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sifre1.HintText = "";
            this.txt_sifre1.isPassword = false;
            this.txt_sifre1.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre1.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sifre1.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre1.LineThickness = 3;
            this.txt_sifre1.Location = new System.Drawing.Point(258, 263);
            this.txt_sifre1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre1.Name = "txt_sifre1";
            this.txt_sifre1.Size = new System.Drawing.Size(235, 32);
            this.txt_sifre1.TabIndex = 14;
            this.txt_sifre1.Text = "Şifre";
            this.txt_sifre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sifre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sifre2.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sifre2.HintText = "";
            this.txt_sifre2.isPassword = false;
            this.txt_sifre2.LineFocusedColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre2.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sifre2.LineMouseHoverColor = System.Drawing.Color.SlateBlue;
            this.txt_sifre2.LineThickness = 3;
            this.txt_sifre2.Location = new System.Drawing.Point(258, 306);
            this.txt_sifre2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.Size = new System.Drawing.Size(235, 33);
            this.txt_sifre2.TabIndex = 15;
            this.txt_sifre2.Text = "Şifre Tekrar";
            this.txt_sifre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RentACarUI.Properties.Resources.AAA_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(271, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Activecolor = System.Drawing.Color.Silver;
            this.btn_kayit.BackColor = System.Drawing.Color.Silver;
            this.btn_kayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayit.BorderRadius = 7;
            this.btn_kayit.ButtonText = "Kayıt Ol";
            this.btn_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_kayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_kayit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_kayit.Iconimage = null;
            this.btn_kayit.Iconimage_right = null;
            this.btn_kayit.Iconimage_right_Selected = null;
            this.btn_kayit.Iconimage_Selected = null;
            this.btn_kayit.IconMarginLeft = 0;
            this.btn_kayit.IconMarginRight = 0;
            this.btn_kayit.IconRightVisible = true;
            this.btn_kayit.IconRightZoom = 0D;
            this.btn_kayit.IconVisible = true;
            this.btn_kayit.IconZoom = 90D;
            this.btn_kayit.IsTab = false;
            this.btn_kayit.Location = new System.Drawing.Point(305, 361);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Normalcolor = System.Drawing.Color.Silver;
            this.btn_kayit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_kayit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_kayit.selected = false;
            this.btn_kayit.Size = new System.Drawing.Size(144, 28);
            this.btn_kayit.TabIndex = 20;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kayit.Textcolor = System.Drawing.Color.Black;
            this.btn_kayit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayit.Click += new System.EventHandler(this.Btn_kayit_Click);
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._2175404;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_sifre2);
            this.Controls.Add(this.txt_sifre1);
            this.Controls.Add(this.txt_email);
            this.Name = "KayitOl";
            this.Size = new System.Drawing.Size(750, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuMaterialTextbox txt_email;
        private ns1.BunifuMaterialTextbox txt_sifre1;
        private ns1.BunifuMaterialTextbox txt_sifre2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton btn_kayit;
    }
}
