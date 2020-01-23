using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarBLL;
using RentACarEntities;
using System.Text.RegularExpressions;
using RentACarContext;

namespace RentACarUI
{
    public partial class KayitOl : UserControl
    {
        public KayitOl()
        {
            InitializeComponent();
            dbContext = RentACarDbContext.DbGetir();
        }
        RentACarDbContext dbContext;
        private void Btn_kayit_Click(object sender, EventArgs e)
        {


            string eMail = txt_email.Text;
            string sifre1 = txt_sifre1.Text;
            string sifre2 = txt_sifre2.Text;


            Regex mailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (mailRegex.IsMatch(eMail))
            {

                var uyeListesi = dbContext.UyeTablosu.Listele();
                var mailList = from m in uyeListesi select m.Email;


                if (!mailList.Contains(eMail))
                {

                    if (sifre1 == sifre2)
                    {
                        bool result = dbContext.UyeTablosu.Ekle(new Uye() { Email = eMail, Sifre = sifre1 });
                        
                        if (result)
                        {
                            MessageBox.Show("Ekleme başarılı");

                            btn_kayit.Enabled = false;
                            btn_kayit.ButtonText = "Kaydedildi✔";
                            btn_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            Uye u = (from uye in dbContext.UyeTablosu.Listele() where uye.Email == eMail select uye).First();

                            AnaMenu.girisYapan = u;
                            AnaMenu a = new AnaMenu();
                            this.Hide();
                            a.Show();
                            
                        }

                        else
                        {
                            MessageBox.Show("Ekleme başarısız");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor");
                    }


                }
                else
                {
                    MessageBox.Show("Böyle bir email sistemde kayıtlı");
                }


            }

            else
            {
                MessageBox.Show("Doğru bir mail adresi giriniz !");
            }


        }
    }
}
