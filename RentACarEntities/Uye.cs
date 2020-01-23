using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarEntities
{
    public class Uye:IEquatable<Uye>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public bool AdminMi { get; set; }
        public bool AktifMi { get; set; }
        public UyeDetay UyeDetay { get; set; }


        public bool Equals(Uye other)
        {
            return this.Email == other.Email && this.Sifre==other.Sifre ? true : false;
        }

        public override string ToString()
        {
            return this.Email;
        }
    }
}
