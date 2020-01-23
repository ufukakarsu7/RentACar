using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentACarDLL
{
    public abstract class Management<T> where T:class
    {

        protected SqlConnection con = Baglanti.BaglantiGetir();
        protected SqlDataReader rdr;
        protected SqlCommand cmd;


        //Create
        public abstract bool Ekle(T t);

        //Read
        public abstract List<T> Listele();

        //Update
        public abstract T Guncelle(T t);
        
        //Delete
        public abstract bool Sil(T t);
       
            


    }
}
