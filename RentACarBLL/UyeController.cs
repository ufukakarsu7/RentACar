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
    public class UyeController : IController<Uye>
    {
        UyeManagment mng = new UyeManagment();
        public bool Ekle(Uye u)
        {
            if (!String.IsNullOrEmpty(u.Email) && !String.IsNullOrEmpty(u.Sifre))
            {
                u.Email = u.Email.ToLower();
                bool result = mng.Ekle(u);
                return result;


            }

            else
            {
                return false;
            }

        }

        public Uye Guncelle(Uye t)
        {
            return mng.Guncelle(t);
        }
        public List<Uye> Listele()
        {
            return mng.Listele();
        }

        public bool Sil(Uye u)
        {
            return mng.Sil(u);

        }

        public bool UyeDetayEkle(UyeDetay u)
        {

            if (!String.IsNullOrEmpty(u.NufusCuzdaniFoto) && !String.IsNullOrEmpty(u.Ad) && !String.IsNullOrEmpty(u.Soyad) && !String.IsNullOrEmpty(u.Memleket) && !String.IsNullOrEmpty(u.NufusCuzdaniFoto))
            {
                long tcK;
                bool onbirHaneMi = long.TryParse(u.Tc, out tcK);
                if (onbirHaneMi)
                {

                    return mng.UyeDetayEkle(u);

                }

                else
                {
                    return false;
                }



            }
            else
            {
                return false;
            }


        }







    }
}
