using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentACarDLL
{
   public class Baglanti
   {


        private static SqlConnection con;

        private Baglanti()
        {

        }

        public static SqlConnection BaglantiGetir()

        {
            if (con == null)
            {
                 con = new SqlConnection(@"Server =.; Database = RentACar; trusted_connection=true;");
            }

            return con;


        }

        


    }
}
