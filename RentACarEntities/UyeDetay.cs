using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities
{
    public class UyeDetay
    {
        public int Id { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        
        public string Memleket { get; set; }

        public string NufusCuzdaniFoto { get; set; }

        public bool? DahaOnceKiraladiMi { get; set; }


    }
}
