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

namespace RentACarUI
{
    public partial class BizeUlasin : UserControl
    {
        public BizeUlasin()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 500)
            {
                MessageBox.Show("500 Karakter Sınırını Aştınız...", "Karakter Sınırı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int karakter = richTextBox1.Text.Length;
                lbl_karakter.Text = Convert.ToString(500 - karakter);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri Hizmetleri Yetkilimiz Sizleri En Kısa Sürede Arayacaktır.", "Canlı Destek", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        UyeController uyeController = new UyeController();
        UyeTalepController uyeTalepController = new UyeTalepController();
        public Uye u;
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            string talepbaslik = txt_baslik.Text;
            string talepaciklama = richTextBox1.Text;
            int uyeId = u.Id;

            bool result = uyeTalepController.UyeTalepEkle(talepbaslik, talepaciklama, uyeId);
            if (result)
            {
                MessageBox.Show("Talebiniz gönderilmiştir.");
            }
            else
            {
                MessageBox.Show("Talebiniz gönderilememiştir.");
            }
        }
    }
}
