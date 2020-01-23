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
    public partial class AdminForm : Form
    {
        public AdminForm(Uye u)
        {
            InitializeComponent();
            girisYapan = u;
        }
        public static Uye girisYapan;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.adminUyeGoruntule1.u = girisYapan;
            if (!String.IsNullOrEmpty(girisYapan.UyeDetay.Ad))
            {
                label1.Text = "Hoşgeldiniz\n" + girisYapan.UyeDetay.Ad.ToUpper() + " " + girisYapan.UyeDetay.Soyad.ToUpper();
            }
            else
            {
                label1.Text = "Hoşgeldiniz,\n" + girisYapan.Email;
            }
        }

        private void btn_talepler_Click(object sender, EventArgs e)
        {
            adminTalepler1.Visible = true;
            adminTalepler1.BringToFront();
        }

        private void btn_uyegoruntule_Click(object sender, EventArgs e)
        {
            adminUyeGoruntule1.Visible = true;
            adminUyeGoruntule1.BringToFront();
        }
    }
}
