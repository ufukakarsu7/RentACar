namespace RentACarUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_talepler = new ns1.BunifuFlatButton();
            this.btn_uyeekle = new ns1.BunifuFlatButton();
            this.btn_aracekle = new ns1.BunifuFlatButton();
            this.btn_rezervasyonlar = new ns1.BunifuFlatButton();
            this.btn_aracgoruntule = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_uyegoruntule = new ns1.BunifuFlatButton();
            this.btn_gonder = new ns1.BunifuFlatButton();
            this.adminUyeGoruntule1 = new RentACarUI.AdminUyeGoruntule();
            this.adminTalepler1 = new RentACarUI.AdminTalepler();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btn_talepler);
            this.panel1.Controls.Add(this.btn_uyeekle);
            this.panel1.Controls.Add(this.btn_aracekle);
            this.panel1.Controls.Add(this.btn_rezervasyonlar);
            this.panel1.Controls.Add(this.btn_aracgoruntule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_uyegoruntule);
            this.panel1.Controls.Add(this.btn_gonder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 450);
            this.panel1.TabIndex = 3;
            // 
            // btn_talepler
            // 
            this.btn_talepler.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_talepler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_talepler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_talepler.BorderRadius = 0;
            this.btn_talepler.ButtonText = "     TALEPLER";
            this.btn_talepler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_talepler.DisabledColor = System.Drawing.Color.Gray;
            this.btn_talepler.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_talepler.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_talepler.Iconimage")));
            this.btn_talepler.Iconimage_right = null;
            this.btn_talepler.Iconimage_right_Selected = null;
            this.btn_talepler.Iconimage_Selected = null;
            this.btn_talepler.IconMarginLeft = 15;
            this.btn_talepler.IconMarginRight = 0;
            this.btn_talepler.IconRightVisible = true;
            this.btn_talepler.IconRightZoom = 0D;
            this.btn_talepler.IconVisible = true;
            this.btn_talepler.IconZoom = 45D;
            this.btn_talepler.IsTab = false;
            this.btn_talepler.Location = new System.Drawing.Point(3, 368);
            this.btn_talepler.Name = "btn_talepler";
            this.btn_talepler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_talepler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_talepler.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_talepler.selected = false;
            this.btn_talepler.Size = new System.Drawing.Size(201, 48);
            this.btn_talepler.TabIndex = 39;
            this.btn_talepler.Text = "     TALEPLER";
            this.btn_talepler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_talepler.Textcolor = System.Drawing.Color.White;
            this.btn_talepler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_talepler.Click += new System.EventHandler(this.btn_talepler_Click);
            // 
            // btn_uyeekle
            // 
            this.btn_uyeekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_uyeekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_uyeekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uyeekle.BorderRadius = 0;
            this.btn_uyeekle.ButtonText = "   ÜYE EKLE";
            this.btn_uyeekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyeekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_uyeekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_uyeekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_uyeekle.Iconimage")));
            this.btn_uyeekle.Iconimage_right = null;
            this.btn_uyeekle.Iconimage_right_Selected = null;
            this.btn_uyeekle.Iconimage_Selected = null;
            this.btn_uyeekle.IconMarginLeft = 15;
            this.btn_uyeekle.IconMarginRight = 0;
            this.btn_uyeekle.IconRightVisible = true;
            this.btn_uyeekle.IconRightZoom = 0D;
            this.btn_uyeekle.IconVisible = true;
            this.btn_uyeekle.IconZoom = 70D;
            this.btn_uyeekle.IsTab = false;
            this.btn_uyeekle.Location = new System.Drawing.Point(3, 152);
            this.btn_uyeekle.Name = "btn_uyeekle";
            this.btn_uyeekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_uyeekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_uyeekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uyeekle.selected = false;
            this.btn_uyeekle.Size = new System.Drawing.Size(201, 48);
            this.btn_uyeekle.TabIndex = 38;
            this.btn_uyeekle.Text = "   ÜYE EKLE";
            this.btn_uyeekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uyeekle.Textcolor = System.Drawing.Color.White;
            this.btn_uyeekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_aracekle
            // 
            this.btn_aracekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_aracekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_aracekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aracekle.BorderRadius = 0;
            this.btn_aracekle.ButtonText = "  ARAÇ EKLE";
            this.btn_aracekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aracekle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aracekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_aracekle.Iconimage = global::RentACarUI.Properties.Resources.cars_inventory_512;
            this.btn_aracekle.Iconimage_right = null;
            this.btn_aracekle.Iconimage_right_Selected = null;
            this.btn_aracekle.Iconimage_Selected = null;
            this.btn_aracekle.IconMarginLeft = 15;
            this.btn_aracekle.IconMarginRight = 0;
            this.btn_aracekle.IconRightVisible = true;
            this.btn_aracekle.IconRightZoom = 0D;
            this.btn_aracekle.IconVisible = true;
            this.btn_aracekle.IconZoom = 75D;
            this.btn_aracekle.IsTab = false;
            this.btn_aracekle.Location = new System.Drawing.Point(3, 260);
            this.btn_aracekle.Name = "btn_aracekle";
            this.btn_aracekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_aracekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_aracekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_aracekle.selected = false;
            this.btn_aracekle.Size = new System.Drawing.Size(201, 48);
            this.btn_aracekle.TabIndex = 37;
            this.btn_aracekle.Text = "  ARAÇ EKLE";
            this.btn_aracekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aracekle.Textcolor = System.Drawing.Color.White;
            this.btn_aracekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_rezervasyonlar
            // 
            this.btn_rezervasyonlar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_rezervasyonlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_rezervasyonlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rezervasyonlar.BorderRadius = 0;
            this.btn_rezervasyonlar.ButtonText = "     REZERVASYONLAR";
            this.btn_rezervasyonlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rezervasyonlar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rezervasyonlar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rezervasyonlar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_rezervasyonlar.Iconimage")));
            this.btn_rezervasyonlar.Iconimage_right = null;
            this.btn_rezervasyonlar.Iconimage_right_Selected = null;
            this.btn_rezervasyonlar.Iconimage_Selected = null;
            this.btn_rezervasyonlar.IconMarginLeft = 15;
            this.btn_rezervasyonlar.IconMarginRight = 0;
            this.btn_rezervasyonlar.IconRightVisible = true;
            this.btn_rezervasyonlar.IconRightZoom = 0D;
            this.btn_rezervasyonlar.IconVisible = true;
            this.btn_rezervasyonlar.IconZoom = 45D;
            this.btn_rezervasyonlar.IsTab = false;
            this.btn_rezervasyonlar.Location = new System.Drawing.Point(3, 314);
            this.btn_rezervasyonlar.Name = "btn_rezervasyonlar";
            this.btn_rezervasyonlar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_rezervasyonlar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_rezervasyonlar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rezervasyonlar.selected = false;
            this.btn_rezervasyonlar.Size = new System.Drawing.Size(201, 48);
            this.btn_rezervasyonlar.TabIndex = 36;
            this.btn_rezervasyonlar.Text = "     REZERVASYONLAR";
            this.btn_rezervasyonlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rezervasyonlar.Textcolor = System.Drawing.Color.White;
            this.btn_rezervasyonlar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_aracgoruntule
            // 
            this.btn_aracgoruntule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_aracgoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_aracgoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aracgoruntule.BorderRadius = 0;
            this.btn_aracgoruntule.ButtonText = "   ARAÇLAR";
            this.btn_aracgoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aracgoruntule.DisabledColor = System.Drawing.Color.Gray;
            this.btn_aracgoruntule.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_aracgoruntule.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_aracgoruntule.Iconimage")));
            this.btn_aracgoruntule.Iconimage_right = null;
            this.btn_aracgoruntule.Iconimage_right_Selected = null;
            this.btn_aracgoruntule.Iconimage_Selected = null;
            this.btn_aracgoruntule.IconMarginLeft = 10;
            this.btn_aracgoruntule.IconMarginRight = 0;
            this.btn_aracgoruntule.IconRightVisible = true;
            this.btn_aracgoruntule.IconRightZoom = 0D;
            this.btn_aracgoruntule.IconVisible = true;
            this.btn_aracgoruntule.IconZoom = 75D;
            this.btn_aracgoruntule.IsTab = false;
            this.btn_aracgoruntule.Location = new System.Drawing.Point(3, 206);
            this.btn_aracgoruntule.Name = "btn_aracgoruntule";
            this.btn_aracgoruntule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_aracgoruntule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_aracgoruntule.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_aracgoruntule.selected = false;
            this.btn_aracgoruntule.Size = new System.Drawing.Size(198, 48);
            this.btn_aracgoruntule.TabIndex = 35;
            this.btn_aracgoruntule.Text = "   ARAÇLAR";
            this.btn_aracgoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aracgoruntule.Textcolor = System.Drawing.Color.White;
            this.btn_aracgoruntule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pictureBox1.Image = global::RentACarUI.Properties.Resources.profil;
            this.pictureBox1.Location = new System.Drawing.Point(19, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_uyegoruntule
            // 
            this.btn_uyegoruntule.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uyegoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_uyegoruntule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uyegoruntule.BorderRadius = 0;
            this.btn_uyegoruntule.ButtonText = "   ÜYE GÖRÜNTÜLE";
            this.btn_uyegoruntule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uyegoruntule.DisabledColor = System.Drawing.Color.Gray;
            this.btn_uyegoruntule.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_uyegoruntule.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_uyegoruntule.Iconimage")));
            this.btn_uyegoruntule.Iconimage_right = null;
            this.btn_uyegoruntule.Iconimage_right_Selected = null;
            this.btn_uyegoruntule.Iconimage_Selected = null;
            this.btn_uyegoruntule.IconMarginLeft = 15;
            this.btn_uyegoruntule.IconMarginRight = 0;
            this.btn_uyegoruntule.IconRightVisible = true;
            this.btn_uyegoruntule.IconRightZoom = 0D;
            this.btn_uyegoruntule.IconVisible = true;
            this.btn_uyegoruntule.IconZoom = 70D;
            this.btn_uyegoruntule.IsTab = false;
            this.btn_uyegoruntule.Location = new System.Drawing.Point(0, 98);
            this.btn_uyegoruntule.Name = "btn_uyegoruntule";
            this.btn_uyegoruntule.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_uyegoruntule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_uyegoruntule.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uyegoruntule.selected = false;
            this.btn_uyegoruntule.Size = new System.Drawing.Size(201, 48);
            this.btn_uyegoruntule.TabIndex = 10;
            this.btn_uyegoruntule.Text = "   ÜYE GÖRÜNTÜLE";
            this.btn_uyegoruntule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uyegoruntule.Textcolor = System.Drawing.Color.White;
            this.btn_uyegoruntule.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uyegoruntule.Click += new System.EventHandler(this.btn_uyegoruntule_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_gonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_gonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gonder.BorderRadius = 7;
            this.btn_gonder.ButtonText = "";
            this.btn_gonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gonder.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_gonder.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_gonder.Iconimage = null;
            this.btn_gonder.Iconimage_right = null;
            this.btn_gonder.Iconimage_right_Selected = null;
            this.btn_gonder.Iconimage_Selected = null;
            this.btn_gonder.IconMarginLeft = 0;
            this.btn_gonder.IconMarginRight = 0;
            this.btn_gonder.IconRightVisible = true;
            this.btn_gonder.IconRightZoom = 0D;
            this.btn_gonder.IconVisible = true;
            this.btn_gonder.IconZoom = 90D;
            this.btn_gonder.IsTab = false;
            this.btn_gonder.Location = new System.Drawing.Point(12, 19);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_gonder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_gonder.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_gonder.selected = false;
            this.btn_gonder.Size = new System.Drawing.Size(183, 75);
            this.btn_gonder.TabIndex = 32;
            this.btn_gonder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_gonder.Textcolor = System.Drawing.Color.White;
            this.btn_gonder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // adminUyeGoruntule1
            // 
            this.adminUyeGoruntule1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminUyeGoruntule1.BackgroundImage")));
            this.adminUyeGoruntule1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminUyeGoruntule1.Location = new System.Drawing.Point(204, 0);
            this.adminUyeGoruntule1.Name = "adminUyeGoruntule1";
            this.adminUyeGoruntule1.Size = new System.Drawing.Size(600, 450);
            this.adminUyeGoruntule1.TabIndex = 4;
            this.adminUyeGoruntule1.Visible = false;
            // 
            // adminTalepler1
            // 
            this.adminTalepler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminTalepler1.BackgroundImage")));
            this.adminTalepler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminTalepler1.Location = new System.Drawing.Point(204, 0);
            this.adminTalepler1.Name = "adminTalepler1";
            this.adminTalepler1.Size = new System.Drawing.Size(600, 450);
            this.adminTalepler1.TabIndex = 5;
            this.adminTalepler1.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminTalepler1);
            this.Controls.Add(this.adminUyeGoruntule1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton btn_uyegoruntule;
        private ns1.BunifuFlatButton btn_gonder;
        private ns1.BunifuFlatButton btn_talepler;
        private ns1.BunifuFlatButton btn_uyeekle;
        private ns1.BunifuFlatButton btn_aracekle;
        private ns1.BunifuFlatButton btn_rezervasyonlar;
        private ns1.BunifuFlatButton btn_aracgoruntule;
        private AdminUyeGoruntule adminUyeGoruntule1;
        private AdminTalepler adminTalepler1;
    }
}