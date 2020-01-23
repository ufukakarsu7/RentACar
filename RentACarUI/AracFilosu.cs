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
using RentACarBLL;

namespace RentACarUI
{
    public partial class AracFilosu : UserControl
    {
        AracController ac = new AracController();
        public AracFilosu()
        {
            InitializeComponent();
            
        }

        int fotoSayaci = 0;
        int sayac = 0;
        List<Arac> AraclarListesi;
        private void AracFilosu_Load(object sender, EventArgs e)
        {
            AraclarListesi = ac.AraclariGetir();
            AracGoster(sayac);

        }

        private void Btn_sag_Click(object sender, EventArgs e)
        {
            fotoSayaci = 0;
            sayac++;
            if (sayac == AraclarListesi.Count) { sayac = 0; }
            AracGoster(sayac);
        }

        private void Btn_sol_Click(object sender, EventArgs e)
        {
            fotoSayaci = 0;
            sayac--;
            if (sayac < 0)
            {

                sayac = AraclarListesi.Count - 1;

            }

            AracGoster(sayac);
        }

        public void AracGoster(int index)
        {
                       
            lbl_fiyat.Text = AraclarListesi[index].Fiyat.ToString()+" ₺";
            lbl_marka.Text = AraclarListesi[index].Marka.Ad;
            lbl_model.Text = AraclarListesi[index].Model;
            lbl_guncelKm.Text = AraclarListesi[index].GuncelKM.ToString();
            lbl_modelYil.Text = AraclarListesi[index].ModelYil.ToString();
            string hedefKlasor = Application.StartupPath + @"/../../../AracFotograflari";
            if (AraclarListesi[index].FotografListesi.Count > 0)
            {

                picture_aracFoto.Image = Image.FromFile(hedefKlasor + "/" + AraclarListesi[index].FotografListesi[fotoSayaci].Foto);

            }
           

        }

        private void Btn_fotoSol_Click(object sender, EventArgs e)
        {
            fotoSayaci--;
            if (fotoSayaci<0)
            {

                fotoSayaci=AraclarListesi[sayac].FotografListesi.Count - 1;

            }
            AracGoster(sayac);
        }

        private void Btn_fotoSag_Click(object sender, EventArgs e)
        {

            fotoSayaci++;
            if (fotoSayaci == AraclarListesi[sayac].FotografListesi.Count)
            {

                fotoSayaci = 0;

            }
            AracGoster(sayac);

        }
    }
}
