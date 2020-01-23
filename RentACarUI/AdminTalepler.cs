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


namespace RentACarUI
{
    public partial class AdminTalepler : UserControl
    {
        public AdminTalepler()
        {
            InitializeComponent();
        }
        UyeTalepController uyeTalepController = new UyeTalepController();
        public void ListeyiYenile()
        {
            listView1.Items.Clear();
            List<UyeTalep> talepler = uyeTalepController.TalepleriGetir();

            if (talepler != null)
            {
                ListViewItem lvi;
                foreach (var item in talepler)
                {
                    lvi = new ListViewItem();
                    lvi.Text = item.Id.ToString();
                    lvi.SubItems.Add(item.TalepBaslik);
                    lvi.SubItems.Add(item.TalepAciklama);
                    lvi.SubItems.Add(item.AdSoyad.ToString());
                    lvi.SubItems.Add(item.UyeMail);
                    if (item.CozulduMu == true)
                    {
                        lvi.SubItems.Add("Evet");
                    }
                    else
                    { lvi.SubItems.Add("Hayır"); }
                    listView1.Items.Add(lvi);
                }

            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            bool cozulduMu = true;
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);

            bool sonuc = uyeTalepController.TalepGuncelle(id, cozulduMu);

            if (sonuc)
            {
                MessageBox.Show("başarıyla güncellendi");
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu");
            }
        }

        private void AdminTalepler_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
    }
}
