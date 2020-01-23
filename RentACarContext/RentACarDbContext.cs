using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarBLL;

namespace RentACarContext
{
    public class RentACarDbContext
    {

        public AracController AracTablosu=new AracController();
        public UyeController UyeTablosu=new UyeController();
        public AracKiraController AracKiraTablosu = new AracKiraController();
        private static RentACarDbContext context;
        private RentACarDbContext()
        {

        }

        public static RentACarDbContext DbGetir()
        {
            if (context == null)
            {
                context = new RentACarDbContext();
            }

            return context;
        }

    }
}
