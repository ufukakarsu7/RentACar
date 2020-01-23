using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACarBLL;
using RentACarEntities;

namespace RentACarUI
{
    public partial class AnaMenu : Form

    {
        public static Uye girisYapan;
        public AnaMenu()
        {

            InitializeComponent();

            this.uyeDetay1.u = girisYapan;
            this.bizeUlasin1.u = girisYapan;
            if (!String.IsNullOrEmpty(girisYapan.UyeDetay.Ad))
            {
                label1.Text = "Hoşgeldiniz\n" + girisYapan.UyeDetay.Ad.ToUpper() + " " + girisYapan.UyeDetay.Soyad.ToUpper();
            }
            else
            {
                label1.Text = "Hoşgeldiniz,\n" + girisYapan.Email;
            }
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
           
        }
        private void btn_uyedetay_Click(object sender, EventArgs e)
        {
            uyeDetay1.u = girisYapan;
            uyeDetay1.Visible = true;
            uyeDetay1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bizeUlasin1.Visible = true;
            bizeUlasin1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            hakkimizda1.Visible = true;
            hakkimizda1.BringToFront();
        }

        private void Btn_aracFilo_Click(object sender, EventArgs e)
        {
            aracFilo1.Visible = true;
            aracFilo1.AracFilo_Load(this, new EventArgs());
            aracFilo1.BringToFront();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            teslimEt1.TeslimEt_Load(this, new EventArgs());
            teslimEt1.BringToFront();
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            kampanyalar1.Visible = true;
            kampanyalar1.BringToFront();
        }

        
    }
}
