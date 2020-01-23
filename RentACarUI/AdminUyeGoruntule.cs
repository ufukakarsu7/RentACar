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
    public partial class AdminUyeGoruntule : UserControl
    {
        public AdminUyeGoruntule()
        {
            InitializeComponent();
        }
        UyeController uyeController = new UyeController();

        //Giriş yapan üyeyi tutmak için.
        public Uye u;
    }
}
