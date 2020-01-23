using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarEntities;


namespace RentACarDLL
{
    public class UyeTalepManagement
    {
        public bool UyeTalepEkle(string talepbaslik, string talepaciklama, int uyeid)
        {
            SqlConnection con = Baglanti.BaglantiGetir();

            SqlCommand cmd = new SqlCommand("SP_UyeTalepEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@talepbaslik", talepbaslik);
            cmd.Parameters.AddWithValue("@talepaciklama", talepaciklama);
            cmd.Parameters.AddWithValue("@uyeId", uyeid);
            int result = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

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

            if (result > 0)
            {
                //Ekleme Başarılı.
                return true;
            }

            else
            {
                //Ekleme Başarısız.
                return false;
            }
        }


        public List<UyeTalep> TalepleriGetir()
        {

            List<UyeTalep> talepListesi = new List<UyeTalep>();

            SqlConnection con = Baglanti.BaglantiGetir();

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("select * from UyeTalep ut join Uye u on ut.UyeId = u.Id join UyeDetay ud on ut.UyeId=ud.Id", con);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        UyeTalep ud = new UyeTalep();

                        ud.Id = Convert.ToInt32(rdr["Id"]);
                        ud.TalepBaslik = (string)rdr["TalepBaslik"];
                        ud.TalepAciklama = (string)rdr["TalepAciklama"];
                        ud.AdSoyad = (string)(rdr["Ad"] + " " + rdr["Soyad"]);
                        ud.UyeMail = (string)rdr["Email"];
                        ud.CozulduMu = (bool)rdr["CozulduMu"];

                        talepListesi.Add(ud);

                    }


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





            return talepListesi;
        }

        public bool TalepGuncelle(int id, bool cozuldumu)
        {
            SqlConnection con = Baglanti.BaglantiGetir();

            SqlCommand cmd = new SqlCommand("update UyeTalep set CozulduMu=@cozulduMu where Id=@id", con);
            cmd.Parameters.AddWithValue("@cozulduMu", cozuldumu);
            cmd.Parameters.AddWithValue("@id", id);

            int result = 0;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

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

            if (result > 0)
            {
                //Ekleme Başarılı.
                return true;
            }

            else
            {
                //Ekleme Başarısız.
                return false;
            }
        }
    }
}
