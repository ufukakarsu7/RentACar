using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarUI
{
    public partial class Kampanyalar : UserControl
    {
        public Kampanyalar()
        {
            InitializeComponent();
        }
        int x = 1;

        private void btn_sag_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                pictureBox2.Image = Properties.Resources.kampanya2;
                x = 2;
                this.BackColor = Color.FromArgb(13, 13, 13);
            }
            else if (x == 2)
            {
                pictureBox2.Image = Properties.Resources.kampanya1;
                x = 1;
                this.BackColor = Color.FromArgb(255, 128, 0);
            }
        }

        private void btn_sol_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                pictureBox2.Image = Properties.Resources.kampanya2;
                x = 2;
                this.BackColor = Color.FromArgb(13, 13, 13);
            }
            else if (x == 2)
            {
                pictureBox2.Image = Properties.Resources.kampanya1;
                x = 1;
                this.BackColor = Color.FromArgb(255, 128, 0);
            }
        }
    }
}
