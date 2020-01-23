using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarEntities;
using RentACarContext;
using RentACarBLL;

namespace RentACarUI
{
    public partial class UyeGirisi : UserControl
    {
        RentACarDbContext dbContext;
        public UyeGirisi()
        {
            InitializeComponent();
            dbContext = RentACarDbContext.DbGetir();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string eMail = txt_email.Text;
            string sifre = txt_sifre.Text;
            Uye uye = new Uye() { Email = eMail, Sifre = sifre };
            var uyeListesi = dbContext.UyeTablosu.Listele();
            bool result=uyeListesi.Contains(uye);
          

            if (!result)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatali", "Giriş yapılamadı", MessageBoxButtons.OK);
            }
            else
            {
                if (uye.AdminMi == true)
                {
                    var girisYapanUye = (from u in uyeListesi where u.Email == eMail && u.Sifre == sifre select u).First();
                    AdminForm.girisYapan = girisYapanUye;
                    AdminForm adminFormu = new AdminForm(uye);
                    this.Parent.Hide();
                    adminFormu.BringToFront();
                    adminFormu.Show();
                }
                else
                {
                    var girisYapanUye = (from u in uyeListesi where u.Email == eMail && u.Sifre == sifre select u).First();
                    AnaMenu.girisYapan = girisYapanUye;
                    AnaMenu anaMenu = new AnaMenu();
                    this.Parent.Hide();
                    anaMenu.BringToFront();
                    anaMenu.Show();
                }
            }
        }
        private void lbl_sifremiunuttum_MouseEnter(object sender, EventArgs e)
        {
            lbl_sifremiunuttum.Font = new Font(lbl_sifremiunuttum.Font, FontStyle.Underline);
        }
        private void lbl_sifremiunuttum_MouseLeave(object sender, EventArgs e)
        {
            lbl_sifremiunuttum.Font = new Font(lbl_sifremiunuttum.Font, FontStyle.Regular);
        }

        private void UyeGirisi_Load(object sender, EventArgs e)
        {
            btn_login.ButtonText = "Giriş Yap";
        }
    }
}
