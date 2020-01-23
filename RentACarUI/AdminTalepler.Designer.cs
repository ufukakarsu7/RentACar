namespace RentACarUI
{
    partial class AdminTalepler
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
            this.btn_guncelle = new ns1.BunifuFlatButton();
            this.lbl_iletisimform = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.talepbaslik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.talepaciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uyeadsoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uyemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cozuldumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Activecolor = System.Drawing.Color.Silver;
            this.btn_guncelle.BackColor = System.Drawing.Color.Silver;
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guncelle.BorderRadius = 7;
            this.btn_guncelle.ButtonText = "GÜNCELLE";
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_guncelle.Iconimage = null;
            this.btn_guncelle.Iconimage_right = null;
            this.btn_guncelle.Iconimage_right_Selected = null;
            this.btn_guncelle.Iconimage_Selected = null;
            this.btn_guncelle.IconMarginLeft = 0;
            this.btn_guncelle.IconMarginRight = 0;
            this.btn_guncelle.IconRightVisible = true;
            this.btn_guncelle.IconRightZoom = 0D;
            this.btn_guncelle.IconVisible = true;
            this.btn_guncelle.IconZoom = 90D;
            this.btn_guncelle.IsTab = false;
            this.btn_guncelle.Location = new System.Drawing.Point(231, 399);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Normalcolor = System.Drawing.Color.Silver;
            this.btn_guncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_guncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guncelle.selected = false;
            this.btn_guncelle.Size = new System.Drawing.Size(144, 28);
            this.btn_guncelle.TabIndex = 41;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guncelle.Textcolor = System.Drawing.Color.Black;
            this.btn_guncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // lbl_iletisimform
            // 
            this.lbl_iletisimform.AutoSize = true;
            this.lbl_iletisimform.BackColor = System.Drawing.Color.Transparent;
            this.lbl_iletisimform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iletisimform.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_iletisimform.Location = new System.Drawing.Point(254, 23);
            this.lbl_iletisimform.Name = "lbl_iletisimform";
            this.lbl_iletisimform.Size = new System.Drawing.Size(82, 21);
            this.lbl_iletisimform.TabIndex = 40;
            this.lbl_iletisimform.Text = "TALEPLER";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.talepbaslik,
            this.talepaciklama,
            this.uyeadsoyad,
            this.uyemail,
            this.cozuldumu});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 319);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Tlp No";
            this.id.Width = 45;
            // 
            // talepbaslik
            // 
            this.talepbaslik.Text = "Talep Başlık";
            this.talepbaslik.Width = 107;
            // 
            // talepaciklama
            // 
            this.talepaciklama.Text = "Talep Açıklama";
            // 
            // uyeadsoyad
            // 
            this.uyeadsoyad.Text = "Uye Ad Soyad";
            // 
            // uyemail
            // 
            this.uyemail.Text = "Uye Mail";
            this.uyemail.Width = 120;
            // 
            // cozuldumu
            // 
            this.cozuldumu.Text = "Çözüldü Mü";
            this.cozuldumu.Width = 71;
            // 
            // AdminTalepler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.lbl_iletisimform);
            this.Controls.Add(this.listView1);
            this.Name = "AdminTalepler";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.AdminTalepler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuFlatButton btn_guncelle;
        private System.Windows.Forms.Label lbl_iletisimform;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader talepbaslik;
        private System.Windows.Forms.ColumnHeader talepaciklama;
        private System.Windows.Forms.ColumnHeader uyeadsoyad;
        private System.Windows.Forms.ColumnHeader uyemail;
        private System.Windows.Forms.ColumnHeader cozuldumu;
    }
}
