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
using System.IO;
using RentACarContext;

namespace RentACarUI
{
    public partial class UyeDetay : UserControl
    {


        //Giriş yapan üyeyi tutmak için.
        public Uye u;

        public UyeDetay()
        {
            
            InitializeComponent();
            

        }

        

        private void UyeDetay_Load(object sender, EventArgs e)
        {
          
            if (u.UyeDetay.DahaOnceKiraladiMi == true)
            {
                txt_ad.Text = u.UyeDetay.Ad;
                txt_soyad.Text = u.UyeDetay.Soyad;
                txt_tc.Text = u.UyeDetay.Tc;
                dt_dogumTarihi.Value = u.UyeDetay.DogumTarihi.Value;
                txt_memleket.Text = u.UyeDetay.Memleket;
                picture_nufus.Image = Image.FromFile(hedefKlasor+"\\"+u.UyeDetay.NufusCuzdaniFoto);

            }

        }



        string fotografPath;
        string hedefKlasor = Application.StartupPath + "\\..\\..\\..\\NufusCuzdanlari";

        private void Btn_nufusCuzdaniEkle_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.jpeg,*.jpg,*.png)|*.jpeg;*.jpg;*.png;";
            DialogResult result = openFile.ShowDialog();


            if (result == DialogResult.OK)
            {

                string kaynakDosya = openFile.FileName;
                var f = openFile.SafeFileName.Split('.');
                string fotograf = Guid.NewGuid().ToString() + "." + f[1];
                File.Copy(kaynakDosya, hedefKlasor + "\\" + fotograf);
                fotografPath = hedefKlasor + "\\" + fotograf;
                picture_nufus.Image = Image.FromFile(fotografPath);

            }



        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            u.UyeDetay.Tc = txt_tc.Text;
            u.UyeDetay.Ad= txt_ad.Text;
            u.UyeDetay.Soyad = txt_soyad.Text;
            u.UyeDetay.Memleket = txt_memleket.Text;
            u.UyeDetay.NufusCuzdaniFoto = fotografPath;
            u.UyeDetay.DogumTarihi = dt_dogumTarihi.Value;
            u.UyeDetay.Id = u.Id;

            var dbContext = RentACarDbContext.DbGetir();

            bool result = dbContext.UyeTablosu.UyeDetayEkle(u.UyeDetay);
            if (result)
            {
                MessageBox.Show("Ekleme başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }

        }


    }
}