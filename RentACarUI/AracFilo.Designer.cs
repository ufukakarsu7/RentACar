namespace RentACarUI
{
    partial class AracFilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracFilo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rd_oto = new System.Windows.Forms.RadioButton();
            this.rd_manuel = new System.Windows.Forms.RadioButton();
            this.nm_fiyat = new System.Windows.Forms.NumericUpDown();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.cmb_marka = new System.Windows.Forms.ComboBox();
            this.btn_kirala = new System.Windows.Forms.Button();
            this.btn_sag = new ns1.BunifuImageButton();
            this.btn_fotoSag = new ns1.BunifuImageButton();
            this.btn_sol = new ns1.BunifuImageButton();
            this.btn_fotoSol = new ns1.BunifuImageButton();
            this.lb_marka = new ns1.BunifuCustomLabel();
            this.lb_model = new ns1.BunifuCustomLabel();
            this.lb_guncelKm = new ns1.BunifuCustomLabel();
            this.lb_fiyat = new ns1.BunifuCustomLabel();
            this.dt_teslim = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fotoSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fotoSol)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.pictureBox1.Location = new System.Drawing.Point(115, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rd_oto);
            this.groupBox1.Controls.Add(this.rd_manuel);
            this.groupBox1.Controls.Add(this.nm_fiyat);
            this.groupBox1.Controls.Add(this.cmb_model);
            this.groupBox1.Controls.Add(this.cmb_marka);
            this.groupBox1.Location = new System.Drawing.Point(400, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 447);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(35, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rd_oto
            // 
            this.rd_oto.AutoSize = true;
            this.rd_oto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_oto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rd_oto.Location = new System.Drawing.Point(35, 216);
            this.rd_oto.Name = "rd_oto";
            this.rd_oto.Size = new System.Drawing.Size(75, 17);
            this.rd_oto.TabIndex = 4;
            this.rd_oto.TabStop = true;
            this.rd_oto.Text = "Otomatik";
            this.rd_oto.UseVisualStyleBackColor = true;
            // 
            // rd_manuel
            // 
            this.rd_manuel.AutoSize = true;
            this.rd_manuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd_manuel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rd_manuel.Location = new System.Drawing.Point(116, 216);
            this.rd_manuel.Name = "rd_manuel";
            this.rd_manuel.Size = new System.Drawing.Size(66, 17);
            this.rd_manuel.TabIndex = 3;
            this.rd_manuel.TabStop = true;
            this.rd_manuel.Text = "Manuel";
            this.rd_manuel.UseVisualStyleBackColor = true;
            // 
            // nm_fiyat
            // 
            this.nm_fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.nm_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nm_fiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nm_fiyat.Location = new System.Drawing.Point(35, 167);
            this.nm_fiyat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nm_fiyat.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nm_fiyat.Name = "nm_fiyat";
            this.nm_fiyat.Size = new System.Drawing.Size(135, 20);
            this.nm_fiyat.TabIndex = 2;
            this.nm_fiyat.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cmb_model
            // 
            this.cmb_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.cmb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_model.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(35, 114);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(135, 21);
            this.cmb_model.TabIndex = 1;
            // 
            // cmb_marka
            // 
            this.cmb_marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.cmb_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_marka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmb_marka.FormattingEnabled = true;
            this.cmb_marka.Location = new System.Drawing.Point(35, 60);
            this.cmb_marka.Name = "cmb_marka";
            this.cmb_marka.Size = new System.Drawing.Size(135, 21);
            this.cmb_marka.TabIndex = 0;
            // 
            // btn_kirala
            // 
            this.btn_kirala.BackColor = System.Drawing.Color.Black;
            this.btn_kirala.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_kirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kirala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kirala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kirala.Location = new System.Drawing.Point(115, 364);
            this.btn_kirala.Name = "btn_kirala";
            this.btn_kirala.Size = new System.Drawing.Size(173, 54);
            this.btn_kirala.TabIndex = 0;
            this.btn_kirala.Text = "KİRALA";
            this.btn_kirala.UseVisualStyleBackColor = false;
            this.btn_kirala.Click += new System.EventHandler(this.Btn_kirala_Click);
            // 
            // btn_sag
            // 
            this.btn_sag.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_sag.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_sag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sag.Image = ((System.Drawing.Image)(resources.GetObject("btn_sag.Image")));
            this.btn_sag.ImageActive = null;
            this.btn_sag.Location = new System.Drawing.Point(307, 72);
            this.btn_sag.Name = "btn_sag";
            this.btn_sag.Size = new System.Drawing.Size(75, 71);
            this.btn_sag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_sag.TabIndex = 6;
            this.btn_sag.TabStop = false;
            this.btn_sag.Zoom = 10;
            this.btn_sag.Click += new System.EventHandler(this.Btn_sag_Click);
            // 
            // btn_fotoSag
            // 
            this.btn_fotoSag.BackColor = System.Drawing.Color.Navy;
            this.btn_fotoSag.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_fotoSag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fotoSag.Image = ((System.Drawing.Image)(resources.GetObject("btn_fotoSag.Image")));
            this.btn_fotoSag.ImageActive = null;
            this.btn_fotoSag.Location = new System.Drawing.Point(294, 90);
            this.btn_fotoSag.Name = "btn_fotoSag";
            this.btn_fotoSag.Size = new System.Drawing.Size(35, 32);
            this.btn_fotoSag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fotoSag.TabIndex = 7;
            this.btn_fotoSag.TabStop = false;
            this.btn_fotoSag.Zoom = 10;
            this.btn_fotoSag.Click += new System.EventHandler(this.Btn_fotoSag_Click);
            // 
            // btn_sol
            // 
            this.btn_sol.BackColor = System.Drawing.Color.Navy;
            this.btn_sol.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_sol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sol.Image = ((System.Drawing.Image)(resources.GetObject("btn_sol.Image")));
            this.btn_sol.ImageActive = null;
            this.btn_sol.Location = new System.Drawing.Point(20, 72);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(71, 71);
            this.btn_sol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_sol.TabIndex = 8;
            this.btn_sol.TabStop = false;
            this.btn_sol.Zoom = 10;
            this.btn_sol.Click += new System.EventHandler(this.Btn_sol_Click);
            // 
            // btn_fotoSol
            // 
            this.btn_fotoSol.BackColor = System.Drawing.Color.Navy;
            this.btn_fotoSol.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.btn_fotoSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fotoSol.Image = ((System.Drawing.Image)(resources.GetObject("btn_fotoSol.Image")));
            this.btn_fotoSol.ImageActive = null;
            this.btn_fotoSol.Location = new System.Drawing.Point(71, 90);
            this.btn_fotoSol.Name = "btn_fotoSol";
            this.btn_fotoSol.Size = new System.Drawing.Size(38, 32);
            this.btn_fotoSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fotoSol.TabIndex = 9;
            this.btn_fotoSol.TabStop = false;
            this.btn_fotoSol.Zoom = 10;
            this.btn_fotoSol.Click += new System.EventHandler(this.Btn_fotoSol_Click);
            // 
            // lb_marka
            // 
            this.lb_marka.AutoSize = true;
            this.lb_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_marka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_marka.Image = ((System.Drawing.Image)(resources.GetObject("lb_marka.Image")));
            this.lb_marka.Location = new System.Drawing.Point(123, 216);
            this.lb_marka.Name = "lb_marka";
            this.lb_marka.Size = new System.Drawing.Size(25, 16);
            this.lb_marka.TabIndex = 10;
            this.lb_marka.Text = "sa";
            this.lb_marka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_model.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_model.Image = ((System.Drawing.Image)(resources.GetObject("lb_model.Image")));
            this.lb_model.Location = new System.Drawing.Point(242, 217);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(25, 16);
            this.lb_model.TabIndex = 11;
            this.lb_model.Text = "sa";
            this.lb_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_guncelKm
            // 
            this.lb_guncelKm.AutoSize = true;
            this.lb_guncelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_guncelKm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_guncelKm.Image = ((System.Drawing.Image)(resources.GetObject("lb_guncelKm.Image")));
            this.lb_guncelKm.Location = new System.Drawing.Point(180, 247);
            this.lb_guncelKm.Name = "lb_guncelKm";
            this.lb_guncelKm.Size = new System.Drawing.Size(25, 16);
            this.lb_guncelKm.TabIndex = 12;
            this.lb_guncelKm.Text = "sa";
            this.lb_guncelKm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_fiyat
            // 
            this.lb_fiyat.AutoSize = true;
            this.lb_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fiyat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_fiyat.Image = ((System.Drawing.Image)(resources.GetObject("lb_fiyat.Image")));
            this.lb_fiyat.Location = new System.Drawing.Point(180, 289);
            this.lb_fiyat.Name = "lb_fiyat";
            this.lb_fiyat.Size = new System.Drawing.Size(25, 16);
            this.lb_fiyat.TabIndex = 13;
            this.lb_fiyat.Text = "sa";
            this.lb_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_teslim
            // 
            this.dt_teslim.Location = new System.Drawing.Point(103, 322);
            this.dt_teslim.MinDate = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
            this.dt_teslim.Name = "dt_teslim";
            this.dt_teslim.Size = new System.Drawing.Size(200, 20);
            this.dt_teslim.TabIndex = 14;
            // 
            // AracFilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACarUI.Properties.Resources._182541;
            this.Controls.Add(this.dt_teslim);
            this.Controls.Add(this.lb_fiyat);
            this.Controls.Add(this.lb_guncelKm);
            this.Controls.Add(this.lb_model);
            this.Controls.Add(this.lb_marka);
            this.Controls.Add(this.btn_fotoSol);
            this.Controls.Add(this.btn_sol);
            this.Controls.Add(this.btn_fotoSag);
            this.Controls.Add(this.btn_sag);
            this.Controls.Add(this.btn_kirala);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AracFilo";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.AracFilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fotoSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fotoSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kirala;
        private ns1.BunifuImageButton btn_sag;
        private ns1.BunifuImageButton btn_fotoSag;
        private ns1.BunifuImageButton btn_sol;
        private ns1.BunifuImageButton btn_fotoSol;
        private ns1.BunifuCustomLabel lb_marka;
        private ns1.BunifuCustomLabel lb_model;
        private ns1.BunifuCustomLabel lb_guncelKm;
        private ns1.BunifuCustomLabel lb_fiyat;
        private System.Windows.Forms.ComboBox cmb_marka;
        private System.Windows.Forms.RadioButton rd_oto;
        private System.Windows.Forms.RadioButton rd_manuel;
        private System.Windows.Forms.NumericUpDown nm_fiyat;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dt_teslim;
    }
}
