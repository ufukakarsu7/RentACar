using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RentACarDLL;
using RentACarEntities;

namespace RentACarBLL
{
    public class UyeTalepController
    {
        UyeTalepManagement mng = new UyeTalepManagement();
        public bool UyeTalepEkle(string talepbaslik, string talepaciklama, int uyeId)
        {
            return mng.UyeTalepEkle(talepbaslik, talepaciklama, uyeId);
        }
        public List<UyeTalep> TalepleriGetir()
        {
            return mng.TalepleriGetir();
        }

        public bool TalepGuncelle(int id, bool cozulduMu)
        {
            try
            {
                mng.TalepGuncelle(id, cozulduMu);

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
