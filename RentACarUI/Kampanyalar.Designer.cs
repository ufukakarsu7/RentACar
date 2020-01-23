namespace RentACarUI
{
    partial class Kampanyalar
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
            this.lbl_kampanya = new System.Windows.Forms.Label();
            this.btn_sag = new System.Windows.Forms.PictureBox();
            this.btn_sol = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kampanya
            // 
            this.lbl_kampanya.AutoSize = true;
            this.lbl_kampanya.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kampanya.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kampanya.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_kampanya.Location = new System.Drawing.Point(223, 22);
            this.lbl_kampanya.Name = "lbl_kampanya";
            this.lbl_kampanya.Size = new System.Drawing.Size(165, 24);
            this.lbl_kampanya.TabIndex = 41;
            this.lbl_kampanya.Text = "KAMPANYALAR";
            // 
            // btn_sag
            // 
            this.btn_sag.BackColor = System.Drawing.Color.Transparent;
            this.btn_sag.Image = global::RentACarUI.Properties.Resources.sagok;
            this.btn_sag.Location = new System.Drawing.Point(554, 213);
            this.btn_sag.Name = "btn_sag";
            this.btn_sag.Size = new System.Drawing.Size(34, 54);
            this.btn_sag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sag.TabIndex = 39;
            this.btn_sag.TabStop = false;
            this.btn_sag.Click += new System.EventHandler(this.btn_sag_Click);
            // 
            // btn_sol
            // 
            this.btn_sol.BackColor = System.Drawing.Color.Transparent;
            this.btn_sol.Image = global::RentACarUI.Properties.Resources.solok;
            this.btn_sol.Location = new System.Drawing.Point(22, 193);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(34, 54);
            this.btn_sol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sol.TabIndex = 43;
            this.btn_sol.TabStop = false;
            this.btn_sol.Click += new System.EventHandler(this.btn_sol_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RentACarUI.Properties.Resources.kampanya1;
            this.pictureBox2.Location = new System.Drawing.Point(44, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(534, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // Kampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btn_sag);
            this.Controls.Add(this.btn_sol);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_kampanya);
            this.Name = "Kampanyalar";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kampanya;
        private System.Windows.Forms.PictureBox btn_sag;
        private System.Windows.Forms.PictureBox btn_sol;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
