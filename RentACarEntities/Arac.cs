using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities
{
    public class Arac
    {
        public int Id { get; set; }

        public Marka Marka { get; set; }

        public string SasiNo { get; set; }

        public int ModelYil { get; set; }

        public int GuncelKM { get; set; }

        public string Model { get; set; }

        public decimal Fiyat { get; set; }

        public bool AktifMi { get; set; }

        public List<Fotograf> FotografListesi = new List<Fotograf>();

        public bool OtomatikVitesMi { get; set; }


        public override string ToString()
        {
            return this.Model;
        }


    }
}
