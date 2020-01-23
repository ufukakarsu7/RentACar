using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarEntities;
using RentACarDLL;

namespace RentACarBLL
{
    public class AracKiraController : IController<AracKira>
    {
        AracKiraManagement mng = new AracKiraManagement();
        public bool Ekle(AracKira t)
        {
            return mng.Ekle(t);
        }

        public AracKira Guncelle(AracKira t)
        {
            return mng.Guncelle(t);
        }

        public List<AracKira> Listele()
        {
            return mng.Listele();
        }

        public bool Sil(AracKira t)
        {
            return mng.Sil(t);
        }
    }
}
