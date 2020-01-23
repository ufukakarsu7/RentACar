using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarEntities;
using System.Data.SqlClient;
using System.Data;

namespace RentACarDLL
{
    public class AracKiraManagement : Management<AracKira>
    {
        int result = 0;
        public override bool Ekle(AracKira t)
        {
            try
            {

                cmd = new SqlCommand("SP_AracKirala", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UyeId", t.UyeId);
                cmd.Parameters.AddWithValue("@AracId", t.AracId);
                cmd.Parameters.AddWithValue("@AlisTarihi", t.AlisTarihi);
                cmd.Parameters.AddWithValue("@TeslimTarihi", t.TeslimTarihi);
                con.Open();

                result = cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return result > 0 ? true : false;



        }

       //Arac Teslim Et
        public override AracKira Guncelle(AracKira t)
        {
            try
            {
                cmd = new SqlCommand("SP_AracTeslimEt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", t.Id);
                cmd.Parameters.AddWithValue("@KiraBedeli",t.KiraBedeli);
                cmd.Parameters.AddWithValue("@TeslimKm", t.TeslimKm);
                cmd.Parameters.AddWithValue("@TeslimTarihi", t.TeslimTarihi);

                con.Open();
                result=cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                con.Close();

            }
            return t;
        }

        public override List<AracKira> Listele()
        {
            List<AracKira> Liste = new List<AracKira>();

            try
            {
                cmd = new SqlCommand("select * from AracKira",con);
                con.Open();
                rdr=cmd.ExecuteReader();

                while (rdr.Read())
                {
                    AracKira k = new AracKira();

                    k.AlinanKm = Convert.ToInt32(rdr["AlinanKm"]);
                    k.AracId = Convert.ToInt32(rdr["AracId"]);
                    k.Id = Convert.ToInt32(rdr["Id"]);
                    k.KiraBedeli = Convert.ToDecimal(rdr["KiraBedeli"]);
                    k.TeslimEdildiMi = Convert.ToBoolean(rdr["TeslimEdildiMi"]);
                    k.TeslimKm = Convert.ToInt32(rdr["TeslimKm"]);
                    k.TeslimTarihi = Convert.ToDateTime(rdr["TeslimTarihi"]);
                    k.UyeId = Convert.ToInt32(rdr["UyeId"]);
                    k.AlisTarihi = Convert.ToDateTime(rdr["AlisTarihi"]);
                    
                    Liste.Add(k);


                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();

            }
            return Liste;
        }

        public override bool Sil(AracKira t)
        {
            throw new NotImplementedException();
        }
    }
}
