using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities
{
    public class AracKira
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public int AracId { get; set; }
        public DateTime AlisTarihi { get; set; }

        public DateTime TeslimTarihi { get; set; }

        public decimal KiraBedeli { get; set; }

        public bool TeslimEdildiMi  { get; set; }

        public int AlinanKm { get; set; }

        public int TeslimKm { get; set; }
    }
}
