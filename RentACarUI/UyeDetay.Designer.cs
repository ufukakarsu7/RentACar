namespace RentACarUI
{
    partial class UyeDetay
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
            this.picture_nufus = new System.Windows.Forms.PictureBox();
            this.txt_memleket = new ns1.BunifuMaterialTextbox();
            this.txt_soyad = new ns1.BunifuMaterialTextbox();
            this.txt_ad = new ns1.BunifuMaterialTextbox();
            this.txt_tc = new ns1.BunifuMaterialTextbox();
            this.dt_dogumTarihi = new ns1.BunifuDatepicker();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.btn_kaydet = new ns1.BunifuFlatButton();
            this.lbl_iletisimform = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture_nufus)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_nufus
            // 
            this.picture_nufus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_nufus.Location = new System.Drawing.Point(334, 105);
            this.picture_nufus.Name = "picture_nufus";
            this.picture_nufus.Size = new System.Drawing.Size(186, 184);
            this.picture_nufus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_nufus.TabIndex = 15;
            this.picture_nufus.TabStop = false;
            // 
            // txt_memleket
            // 
            this.txt_memleket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_memleket.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_memleket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_memleket.HintForeColor = System.Drawing.Color.Empty;
            this.txt_memleket.HintText = "";
            this.txt_memleket.isPassword = false;
            this.txt_memleket.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_memleket.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_memleket.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_memleket.LineThickness = 3;
            this.txt_memleket.Location = new System.Drawing.Point(86, 296);
            this.txt_memleket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_memleket.Name = "txt_memleket";
            this.txt_memleket.Size = new System.Drawing.Size(209, 32);
            this.txt_memleket.TabIndex = 13;
            this.txt_memleket.Text = "Memleket";
            this.txt_memleket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_soyad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_soyad.HintText = "";
            this.txt_soyad.isPassword = false;
            this.txt_soyad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_soyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_soyad.LineThickness = 3;
            this.txt_soyad.Location = new System.Drawing.Point(86, 201);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(209, 32);
            this.txt_soyad.TabIndex = 12;
            this.txt_soyad.Text = "Soyad";
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ad
            // 
            this.txt_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ad.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ad.HintText = "";
            this.txt_ad.isPassword = false;
            this.txt_ad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ad.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ad.LineThickness = 3;
            this.txt_ad.Location = new System.Drawing.Point(86, 154);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(209, 29);
            this.txt_ad.TabIndex = 11;
            this.txt_ad.Text = "Ad";
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_tc
            // 
            this.txt_tc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_tc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tc.HintForeColor = System.Drawing.Color.Empty;
            this.txt_tc.HintText = "";
            this.txt_tc.isPassword = false;
            this.txt_tc.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_tc.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_tc.LineThickness = 3;
            this.txt_tc.Location = new System.Drawing.Point(86, 105);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(209, 32);
            this.txt_tc.TabIndex = 10;
            this.txt_tc.Text = "TC";
            this.txt_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dt_dogumTarihi
            // 
            this.dt_dogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dt_dogumTarihi.BorderRadius = 7;
            this.dt_dogumTarihi.ForeColor = System.Drawing.Color.White;
            this.dt_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dogumTarihi.FormatCustom = "dd.MM.yyyy";
            this.dt_dogumTarihi.Location = new System.Drawing.Point(86, 254);
            this.dt_dogumTarihi.Name = "dt_dogumTarihi";
            this.dt_dogumTarihi.Size = new System.Drawing.Size(209, 30);
            this.dt_dogumTarihi.TabIndex = 19;
            this.dt_dogumTarihi.Value = new System.DateTime(2019, 10, 12, 19, 3, 24, 438);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "Nüfus Cüzdanı Ekle";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(355, 298);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(144, 30);
            this.bunifuFlatButton2.TabIndex = 20;
            this.bunifuFlatButton2.Text = "Nüfus Cüzdanı Ekle";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.Btn_nufusCuzdaniEkle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kaydet.BorderRadius = 7;
            this.btn_kaydet.ButtonText = "KAYDET";
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.DisabledColor = System.Drawing.Color.Gray;
            this.btn_kaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_kaydet.Iconimage = null;
            this.btn_kaydet.Iconimage_right = null;
            this.btn_kaydet.Iconimage_right_Selected = null;
            this.btn_kaydet.Iconimage_Selected = null;
            this.btn_kaydet.IconMarginLeft = 0;
            this.btn_kaydet.IconMarginRight = 0;
            this.btn_kaydet.IconRightVisible = true;
            this.btn_kaydet.IconRightZoom = 0D;
            this.btn_kaydet.IconVisible = true;
            this.btn_kaydet.IconZoom = 90D;
            this.btn_kaydet.IsTab = false;
            this.btn_kaydet.Location = new System.Drawing.Point(232, 366);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kaydet.OnHovercolor = System.Drawing.Color.DimGray;
            this.btn_kaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_kaydet.selected = false;
            this.btn_kaydet.Size = new System.Drawing.Size(154, 33);
            this.btn_kaydet.TabIndex = 21;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kaydet.Textcolor = System.Drawing.Color.White;
            this.btn_kaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_iletisimform
            // 
            this.lbl_iletisimform.AutoSize = true;
            this.lbl_iletisimform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iletisimform.Location = new System.Drawing.Point(82, 58);
            this.lbl_iletisimform.Name = "lbl_iletisimform";
            this.lbl_iletisimform.Size = new System.Drawing.Size(147, 21);
            this.lbl_iletisimform.TabIndex = 37;
            this.lbl_iletisimform.Text = "ÜYE BİLGİ FORMU";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(33, 26);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(534, 398);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UyeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_iletisimform);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dt_dogumTarihi);
            this.Controls.Add(this.picture_nufus);
            this.Controls.Add(this.txt_memleket);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Name = "UyeDetay";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.UyeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_nufus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_nufus;
        private ns1.BunifuMaterialTextbox txt_memleket;
        private ns1.BunifuMaterialTextbox txt_soyad;
        private ns1.BunifuMaterialTextbox txt_ad;
        private ns1.BunifuMaterialTextbox txt_tc;
        private ns1.BunifuDatepicker dt_dogumTarihi;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton btn_kaydet;
        private System.Windows.Forms.Label lbl_iletisimform;
        private ns1.BunifuFlatButton bunifuFlatButton1;
    }
}
