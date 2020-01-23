using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            btn_signup.ButtonText = "Kayıt Ol";
            uyeGirisi1.BringToFront();
            btn_signup.BringToFront();

        }


        private void Btn_login_Click_1(object sender, EventArgs e)
        {
            btn_signup.ButtonText = "Kayıt Ol";
            uyeGirisi1.BringToFront();
            btn_signup.BringToFront();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            
            kayitOl1.BringToFront();
        }
    }
}
