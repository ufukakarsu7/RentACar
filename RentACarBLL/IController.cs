using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBLL
{
    interface IController<T>
    {
         bool Ekle(T t);

        //Read
        List<T> Listele();

        //Update
        T Guncelle(T t);

        //Delete
        bool Sil(T t);

    }
}
