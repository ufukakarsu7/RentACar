using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarDLL;
using RentACarEntities;

namespace RentACarBLL
{
    public class AracController : IController<Arac>
    {
        AracManagment ac = new AracManagment();
        public bool Ekle(Arac t)
        {
            return ac.Ekle(t);
            
        }

        public Arac Guncelle(Arac t)
        {
            return ac.Guncelle(t);
        }

        public List<Arac> Listele()
        {
            return ac.Listele();
        }

        public bool Sil(Arac t)
        {
            return ac.Sil(t);
        }
    }
}
