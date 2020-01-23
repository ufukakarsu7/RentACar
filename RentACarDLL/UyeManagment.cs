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
    public class UyeManagment : Management<Uye>
    {

        public bool UyeDetayEkle(UyeDetay u)
        {
           
            cmd = new SqlCommand("SP_UyeDetayEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@tc", u.Tc);
            cmd.Parameters.AddWithValue("@ad", u.Ad);
            cmd.Parameters.AddWithValue("@soyad", u.Soyad);
            cmd.Parameters.AddWithValue("@dogumtarihi", u.DogumTarihi);
            cmd.Parameters.AddWithValue("@memleket", u.Memleket);
            cmd.Parameters.AddWithValue("@nufuscuzdani", u.NufusCuzdaniFoto);


            int result = 0;

            try
            {
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

        public override bool Ekle(Uye t)
        {
            cmd = new SqlCommand("SP_UyeEkle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", t.Email);
            cmd.Parameters.AddWithValue("@Sifre", t.Sifre);

            int result = 0;

            try
            {
     
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

        public override List<Uye> Listele()
        {
            List<Uye> uyeListesi = new List<Uye>();
            try
            {
                 cmd = new SqlCommand("select * from Uye u join UyeDetay ud on u.Id = ud.Id", con);
                con.Open();
                 rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        Uye u = new Uye();

                        u.Id = Convert.ToInt32(rdr["Id"]);
                        u.Email = (string)rdr["Email"];
                        u.Sifre = (string)rdr["Sifre"];
                        u.AdminMi = (bool)rdr["AdminMi"];
                        u.AktifMi = (bool)rdr["AktifMi"];
                        u.UyeDetay = new UyeDetay();

                        if (Convert.ToBoolean(rdr["DahaOnceKiraladiMi"]) == true)

                        {

                            u.UyeDetay.Tc = Convert.ToString(rdr["Tc"]);
                            u.UyeDetay.Ad = Convert.ToString(rdr["Ad"]);
                            u.UyeDetay.Soyad = Convert.ToString(rdr["Soyad"]);
                            u.UyeDetay.DahaOnceKiraladiMi = Convert.ToBoolean(rdr["DahaOnceKiraladiMi"]);
                            u.UyeDetay.DogumTarihi = Convert.ToDateTime(rdr["DogumTarihi"]);
                            u.UyeDetay.Memleket = Convert.ToString(rdr["Memleket"]);
                            u.UyeDetay.NufusCuzdaniFoto = Convert.ToString(rdr["NufusCuzdani"]);


                        }
                        uyeListesi.Add(u);

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

            return uyeListesi;

        }

        public override Uye Guncelle(Uye t)
        {
            throw new NotImplementedException();
        }

        public override bool Sil(Uye t)
        {
            int result=0;

            try
            {
                cmd = new SqlCommand("update uye set AktifMi='false' where Id=@id");
                cmd.Parameters.AddWithValue("@id", t.Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                con.Close();
            }

            return result >0 ? true : false;
        }
    }






}

