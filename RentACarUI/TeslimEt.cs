using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarContext;
using RentACarEntities;

namespace RentACarUI
{
    public partial class TeslimEt : UserControl
    {
        RentACarDbContext dbContext;
        public Uye girisYapan;
        public TeslimEt()
        {
            InitializeComponent();
            dbContext = RentACarDbContext.DbGetir();
        }

        string hedefKlasor = Application.StartupPath + "\\..\\..\\..\\AracFotograflari";
        Arac kiralananArac;
        AracKira kiraBilgileri;
        
        public void TeslimEt_Load(object sender, EventArgs e)
        {
            var kiraListesi = dbContext.AracKiraTablosu.Listele();
            var aracListesi = dbContext.AracTablosu.Listele();
            //Teslim etmediği aracı çekiyoruz
            var kira = (from k in kiraListesi join a in aracListesi on k.AracId equals a.Id where k.UyeId == AnaMenu.girisYapan.Id && k.TeslimEdildiMi == false select a).FirstOrDefault(); 
            kiraBilgileri= (from k in kiraListesi join a in aracListesi on k.AracId equals a.Id where k.UyeId == AnaMenu.girisYapan.Id && k.TeslimEdildiMi == false select k).FirstOrDefault();
            if (kira != null)
            {
                kiralananArac = kira;
                AracGoster(kira);

            }


        }

        public void AracGoster(Arac a)
        {
            lb_fiyat.Text = a.Fiyat.ToString();
            nm_guncelKm.Minimum = a.GuncelKM;
            nm_guncelKm.Maximum = nm_guncelKm.Minimum + 5000;
            nm_guncelKm.Value = a.GuncelKM;


            lb_marka.Text = a.Marka.Ad.ToString();
            lb_model.Text = a.Model.ToString();

            if (a.FotografListesi.Count > 0)
            {
                pictureBox1.Image = Image.FromFile(hedefKlasor + "\\" + a.FotografListesi[0].Foto);
            }

        }

        private void Btn_teslimEt_Click(object sender, EventArgs e)
        {
            if (kiralananArac != null&&kiraBilgileri!=null)
            {
                btn_teslimEt.Enabled = true;
                kiraBilgileri.TeslimKm = (int)nm_guncelKm.Value;


                int gunSayisi = (kiraBilgileri.TeslimTarihi - kiraBilgileri.AlisTarihi).Days;
                if ((DateTime.Now - kiraBilgileri.TeslimTarihi).Days>0)
                {
                    gunSayisi += (DateTime.Now - kiraBilgileri.TeslimTarihi).Days ;
                }

                decimal Ucret = gunSayisi * kiralananArac.Fiyat;

                kiraBilgileri.KiraBedeli = Ucret;

                MessageBox.Show(Ucret.ToString());

                dbContext.AracKiraTablosu.Guncelle(kiraBilgileri);
                
                TeslimEt_Load(this, new EventArgs()); 

            }
            
        }
    }
}
