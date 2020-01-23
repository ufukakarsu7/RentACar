using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACarEntities;
using System.Data;

namespace RentACarDLL
{
    public class AracManagment : Management<Arac>
    {


        public override bool Ekle(Arac t)
        {
            int result;

            try
            {
                cmd = new SqlCommand("SP_AracEkle",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MarkaId", t.Marka.Id);
                cmd.Parameters.AddWithValue("@Model", t.Model);
                cmd.Parameters.AddWithValue("@SasiNo", t.SasiNo);
                cmd.Parameters.AddWithValue("@ModelYil", t.ModelYil);
                cmd.Parameters.AddWithValue("@GuncelKM", t.GuncelKM);
                cmd.Parameters.AddWithValue("@Fiyat", t.Fiyat);
                cmd.Parameters.AddWithValue("@AktifMi", "true");
                cmd.Parameters.AddWithValue("@OtomatikVitesMi", t.OtomatikVitesMi);
                cmd.Parameters.AddWithValue("@foto1", t.FotografListesi[0].Foto);
                cmd.Parameters.AddWithValue("@foto2", t.FotografListesi[1].Foto);
                cmd.Parameters.AddWithValue("@foto3", t.FotografListesi[2].Foto);
                cmd.Parameters.AddWithValue("@foto4", t.FotografListesi[3].Foto);
                cmd.Parameters.AddWithValue("@foto5", t.FotografListesi[4].Foto);
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

            return result > 0 ? true : false;

        }

        public override Arac Guncelle(Arac t)
        {

            int result;
           

            try
            {

                cmd = new SqlCommand("update Arac set GuncelKM=@guncel where Id=@id", con);
                cmd.Parameters.AddWithValue("@guncel", t.GuncelKM);
                cmd.Parameters.AddWithValue("@id", t.Id);
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


            return t;

        }

        public override List<Arac> Listele()
        {
            List<Arac> AraclarListesi = new List<Arac>();
           
            try
            {


                cmd = new SqlCommand("select * from Arac a join Marka m on a.markaId=m.Id", con);
               
                con.Open();
                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {


                    while (rdr.Read())
                    {

                        Arac a = new Arac();

                        a.Model = (string)rdr["Model"];
                        a.ModelYil = (int)rdr["ModelYil"];
                        a.Fiyat = (decimal)rdr["Fiyat"];
                        a.GuncelKM = (int)rdr["GuncelKM"];
                        a.Id = (int)rdr["Id"];
                        a.SasiNo = (string)rdr["SasiNo"];
                        a.AktifMi = (bool)rdr["AktifMi"];
                        a.OtomatikVitesMi = (bool)rdr["OtomatikVitesMi"];
                        a.Marka = new Marka() { Ad = (string)rdr["Ad"], Id = (int)rdr["MarkaId"] };


                        AraclarListesi.Add(a);
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

            foreach (var arac in AraclarListesi)
            {
                arac.FotografListesi = AracFotoGetir(arac.Id);
            }


            return AraclarListesi;
        }

        public override bool Sil(Arac t)
        {
            int result;
           
            try
            {
                cmd = new SqlCommand("update Arac set AktifMi='false' where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", t.Id);

                con.Open();
                result = (int)cmd.ExecuteNonQuery();

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

        private List<Fotograf> AracFotoGetir(int id)
        {
            List<Fotograf> FotografListesi = new List<Fotograf>();
            cmd = new SqlCommand("select * from Fotograf where aracId=@id",con);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();

                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        Fotograf f = new Fotograf()
                        {
                            AracId = (int)rdr["AracId"],
                            Foto = (string)rdr["Foto"],
                            Id = (int)rdr["Id"]

                        };
                        FotografListesi.Add(f);


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

            return FotografListesi;

        }

     

    }
}
