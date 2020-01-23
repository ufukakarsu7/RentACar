namespace RentACarUI
{
    partial class TeslimEt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeslimEt));
            this.lb_fiyat = new ns1.BunifuCustomLabel();
            this.lb_model = new ns1.BunifuCustomLabel();
            this.lb_marka = new ns1.BunifuCustomLabel();
            this.btn_teslimEt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nm_guncelKm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_guncelKm)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_fiyat
            // 
            this.lb_fiyat.AutoSize = true;
            this.lb_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_fiyat.Image = ((System.Drawing.Image)(resources.GetObject("lb_fiyat.Image")));
            this.lb_fiyat.Location = new System.Drawing.Point(289, 310);
            this.lb_fiyat.Name = "lb_fiyat";
            this.lb_fiyat.Size = new System.Drawing.Size(25, 16);
            this.lb_fiyat.TabIndex = 24;
            this.lb_fiyat.Text = "sa";
            this.lb_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_model.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_model.Image = ((System.Drawing.Image)(resources.GetObject("lb_model.Image")));
            this.lb_model.Location = new System.Drawing.Point(289, 245);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(25, 16);
            this.lb_model.TabIndex = 22;
            this.lb_model.Text = "sa";
            this.lb_model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_marka
            // 
            this.lb_marka.AutoSize = true;
            this.lb_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_marka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_marka.Image = ((System.Drawing.Image)(resources.GetObject("lb_marka.Image")));
            this.lb_marka.Location = new System.Drawing.Point(289, 216);
            this.lb_marka.Name = "lb_marka";
            this.lb_marka.Size = new System.Drawing.Size(25, 16);
            this.lb_marka.TabIndex = 21;
            this.lb_marka.Text = "sa";
            this.lb_marka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_teslimEt
            // 
            this.btn_teslimEt.BackColor = System.Drawing.Color.Black;
            this.btn_teslimEt.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_teslimEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_teslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teslimEt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_teslimEt.Location = new System.Drawing.Point(221, 347);
            this.btn_teslimEt.Name = "btn_teslimEt";
            this.btn_teslimEt.Size = new System.Drawing.Size(173, 54);
            this.btn_teslimEt.TabIndex = 20;
            this.btn_teslimEt.Text = "Teslim ET";
            this.btn_teslimEt.UseVisualStyleBackColor = false;
            this.btn_teslimEt.Click += new System.EventHandler(this.Btn_teslimEt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.pictureBox1.Location = new System.Drawing.Point(206, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // nm_guncelKm
            // 
            this.nm_guncelKm.Location = new System.Drawing.Point(249, 278);
            this.nm_guncelKm.Name = "nm_guncelKm";
            this.nm_guncelKm.Size = new System.Drawing.Size(120, 20);
            this.nm_guncelKm.TabIndex = 25;
            // 
            // TeslimEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.Controls.Add(this.nm_guncelKm);
            this.Controls.Add(this.lb_fiyat);
            this.Controls.Add(this.lb_model);
            this.Controls.Add(this.lb_marka);
            this.Controls.Add(this.btn_teslimEt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeslimEt";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.TeslimEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_guncelKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel lb_fiyat;
        private ns1.BunifuCustomLabel lb_model;
        private ns1.BunifuCustomLabel lb_marka;
        private System.Windows.Forms.Button btn_teslimEt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nm_guncelKm;
    }
}
