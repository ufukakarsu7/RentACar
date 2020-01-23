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
    public partial class AracFilo : UserControl
    {
        RentACarDbContext dbContext;
        public Uye girisYapan;

        public AracFilo()
        {
            dbContext = RentACarDbContext.DbGetir();
            InitializeComponent();
        }
        List<Arac> musaitAraclar;
        List<Arac> aracListesi;
        public void AracFilo_Load(object sender, EventArgs e)
        {
           aracListesi =dbContext.AracTablosu.Listele();
            musaitAraclar = (from a in aracListesi where a.AktifMi == true select a).ToList();
            AracGoster();
            var markalar =(from m in musaitAraclar select m.Marka.Ad).Distinct().ToArray();
            var modeller = (from m in musaitAraclar select m.Model).Distinct().ToArray();
            cmb_marka.Items.AddRange(markalar);
            cmb_model.Items.AddRange(modeller);
            cmb_model.SelectedIndex = 0;
            cmb_marka.SelectedIndex = 0;
            rd_oto.Checked = true;

        }

        int aracSayaci = 0;
        private void Btn_sag_Click(object sender, EventArgs e)
        {
            aracSayaci++;
            if (aracSayaci == musaitAraclar.Count)
            {
                aracSayaci = 0;

            }
            fotoSayaci = 0;
            AracGoster();

        }
        private void Btn_sol_Click(object sender, EventArgs e)
        {
            aracSayaci--;
            if (aracSayaci == -1)
            {
                aracSayaci = musaitAraclar.Count - 1;

            }
            fotoSayaci = 0;
            AracGoster();

        }
        string hedefKlasor = Application.StartupPath + "\\..\\..\\..\\AracFotograflari";
        public void AracGoster()
        {

            if (musaitAraclar.Count>0)
            {
                lb_fiyat.Text = musaitAraclar[aracSayaci].Fiyat.ToString() + " TL";
                lb_guncelKm.Text = musaitAraclar[aracSayaci].GuncelKM.ToString()+" KM";
                lb_marka.Text = musaitAraclar[aracSayaci].Marka.Ad.ToString();
                lb_model.Text = musaitAraclar[aracSayaci].Model.ToString();

                 if (musaitAraclar[aracSayaci].FotografListesi.Count > 0)
                {
                    pictureBox1.Image = Image.FromFile(hedefKlasor + "\\" + musaitAraclar[aracSayaci].FotografListesi[fotoSayaci].Foto);
                }
                
            }
        



        }

        int fotoSayaci = 0;
        private void Btn_fotoSag_Click(object sender, EventArgs e)
        {
            fotoSayaci++;
            if (musaitAraclar.Count>0 && fotoSayaci == musaitAraclar[aracSayaci].FotografListesi.Count)
            {
                fotoSayaci = 0;

            }
            AracGoster();

        }

        private void Btn_fotoSol_Click(object sender, EventArgs e)
        {
            fotoSayaci--;
            if (musaitAraclar.Count > 0 && fotoSayaci == -1)
            {
                fotoSayaci = musaitAraclar[aracSayaci].FotografListesi.Count-1;

            }
            AracGoster();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string marka=cmb_marka.SelectedItem.ToString();
            string model = cmb_model.SelectedItem.ToString();
            bool otomatikVitesMi = rd_oto.Checked == true ? true : false;
            decimal fiyat = nm_fiyat.Value;

            musaitAraclar = (from m in aracListesi where m.Marka.Ad == marka && m.Model == model && m.OtomatikVitesMi == otomatikVitesMi && m.Fiyat < fiyat select m).ToList();
            if (musaitAraclar.Count == 0)
            {
                btn_kirala.Enabled = false;
                
            }
            else if(musaitAraclar.Count>0)
            {
                btn_kirala.Enabled = true;

            }

            aracSayaci = 0;
            fotoSayaci = 0;
            AracGoster();

        }

        private void Btn_kirala_Click(object sender, EventArgs e)
        {
            var kiraListesi = dbContext.AracKiraTablosu.Listele();
            var kira = (from k in kiraListesi where k.UyeId == AnaMenu.girisYapan.Id && k.TeslimEdildiMi == false select k).ToList();

            if (kira.Count > 0)
            {
                MessageBox.Show("Önce kiraladığınız aracı teslim ediniz");
                return;

            }

            if (!String.IsNullOrEmpty(AnaMenu.girisYapan.UyeDetay.NufusCuzdaniFoto))
            {

                Arac secilenArac = musaitAraclar[aracSayaci];
                AracKira ak = new AracKira()
                {
                    UyeId = AnaMenu.girisYapan.Id,
                    AracId = secilenArac.Id,
                    AlisTarihi = DateTime.Now.Date,
                    TeslimTarihi = dt_teslim.Value

                };
                bool result = dbContext.AracKiraTablosu.Ekle(ak);
                if (result) MessageBox.Show("Kiralama işlemi başarılı");
                else
                {
                    MessageBox.Show("Kiralama işlemi başarısız");
                }
            }

            else
            {
                MessageBox.Show("Üye Detay Bilgileriniz eksik lütfen doldurunuz");
            }


        }
    }
}
