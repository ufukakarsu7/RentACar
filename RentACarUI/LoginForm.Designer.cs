namespace RentACarUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_signup = new ns1.BunifuFlatButton();
            this.btn_login = new ns1.BunifuFlatButton();
            this.uyeGirisi1 = new RentACarUI.UyeGirisi();
            this.kayitOl1 = new RentACarUI.KayitOl();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Activecolor = System.Drawing.Color.Silver;
            this.btn_signup.BackColor = System.Drawing.Color.Silver;
            this.btn_signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signup.BorderRadius = 7;
            this.btn_signup.ButtonText = "Kayıt Ol";
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_signup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_signup.Iconimage = null;
            this.btn_signup.Iconimage_right = null;
            this.btn_signup.Iconimage_right_Selected = null;
            this.btn_signup.Iconimage_Selected = null;
            this.btn_signup.IconMarginLeft = 0;
            this.btn_signup.IconMarginRight = 0;
            this.btn_signup.IconRightVisible = true;
            this.btn_signup.IconRightZoom = 0D;
            this.btn_signup.IconVisible = true;
            this.btn_signup.IconZoom = 90D;
            this.btn_signup.IsTab = false;
            this.btn_signup.Location = new System.Drawing.Point(299, 378);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Normalcolor = System.Drawing.Color.Silver;
            this.btn_signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_signup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_signup.selected = false;
            this.btn_signup.Size = new System.Drawing.Size(144, 28);
            this.btn_signup.TabIndex = 22;
            this.btn_signup.Text = "Kayıt Ol";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signup.Textcolor = System.Drawing.Color.Black;
            this.btn_signup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
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
            this.btn_login.Location = new System.Drawing.Point(303, 397);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.Silver;
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(144, 28);
            this.btn_login.TabIndex = 23;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.Black;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click_1);
            // 
            // uyeGirisi1
            // 
            this.uyeGirisi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uyeGirisi1.BackgroundImage")));
            this.uyeGirisi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uyeGirisi1.Location = new System.Drawing.Point(-2, 1);
            this.uyeGirisi1.Name = "uyeGirisi1";
            this.uyeGirisi1.Size = new System.Drawing.Size(750, 450);
            this.uyeGirisi1.TabIndex = 24;
            // 
            // kayitOl1
            // 
            this.kayitOl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayitOl1.BackgroundImage")));
            this.kayitOl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kayitOl1.Location = new System.Drawing.Point(-2, 1);
            this.kayitOl1.Name = "kayitOl1";
            this.kayitOl1.Size = new System.Drawing.Size(750, 450);
            this.kayitOl1.TabIndex = 25;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.uyeGirisi1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.kayitOl1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuFlatButton btn_signup;
        private ns1.BunifuFlatButton btn_login;
        private UyeGirisi uyeGirisi1;
        private KayitOl kayitOl1;
    }
}