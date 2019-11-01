using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLojikLayer
{
    public class DLL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnvalues;
        public static Guid gelendi;
        
        public DLL()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=Yonetim;User ID=sa;Password=1234");


        }
        public void  baglantiayari()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            else
                conn.Close();

        }
        //Yönetici Girişi
        public int sistemkontrol(EntitiesKull K)
        {
            
            try
            {
                cmd = new SqlCommand("select count(*)from Kullanicilar where kullaniciadi=(select kullaniciadi from yetkiler where kullaniciadi=@kullaniciadi and kullaniciyetki='yonetici')and kullaniciadi=@kullaniciadi and sifre=@sifre", conn);


                
                 cmd.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = K.kullaniciadi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = K.sifre;
                
                baglantiayari();
                returnvalues=(int)cmd.ExecuteScalar();

                Guid gelen = K.ID;

            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                baglantiayari();

            }
            return returnvalues;
            

        }


       



        //Sistem Girişi
        public int  yetkidisigiris(Entities.EntitiesKull Y)
        {
            try
            {
                cmd = new SqlCommand("select count(*)from Kullanicilar where kullaniciadi=@kullaniciadi and sifre=@sifre", conn);



                cmd.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = Y.kullaniciadi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = Y.sifre;

                baglantiayari();
                returnvalues = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {

                
            }
            finally
            {
                baglantiayari();

            }

            return returnvalues;


        }

        
        //Sisteme kullanıcı ekleme
        public int kytekle(Entities.EntitiesKull K)
        {
            Guid gelendi = Guid.NewGuid();

            try
            {
                
                cmd = new SqlCommand("insert into Kullanicilar(ID,kullaniciadi,sifre,adi,soyadi,eposta)values(@ID,@kullaniciadi,@sifre,@adi,@soyadi,@eposta)", conn);

                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = gelendi;
                cmd.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = K.kullaniciadi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = K.sifre;
                cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = K.adi;
                cmd.Parameters.Add("@soyadi", SqlDbType.NVarChar).Value = K.soyadi;
                cmd.Parameters.Add("@eposta", SqlDbType.NVarChar).Value = K.eposta;
                baglantiayari();
                 returnvalues=cmd.ExecuteNonQuery();

                
                
            }
            catch (Exception ex)
            {

              
            }
            finally
            {
                baglantiayari();
            }
           
           
            return returnvalues;
            

        }
        
        //sisteme yetkili kullanıcı verme
        public int kytyetkiver(Entities.EntitiesKull K)
        {

            try
            {

                cmd = new SqlCommand("insert into Yetkiler(ID,kullaniciadi,sifre,kullaniciyetki)values(@ID,@kullaniciadi,@sifre,'yonetici')", conn);

                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value =K.ID ;
                cmd.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = K.kullaniciadi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = K.sifre;
                
                baglantiayari();
                returnvalues = cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {


            }
            finally
            {
                baglantiayari();
            }
            return returnvalues;


        }


        //çift tıklayınca yetki kaldırılsınmı
        public int yetkikaldir(Guid ID)
        {
            try
            {
                cmd = new SqlCommand(@"delete Yetkiler where ID=@ID", conn);

                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = ID;
                baglantiayari();
                returnvalues = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {


            }
            finally
            {
                baglantiayari();
            }
            return returnvalues;


        }


        public int kytduzenle(EntitiesKull K)
        {
            try
            {
                cmd = new SqlCommand(@"update Kullanicilar set kullaniciadi=@kullaniciadi,sifre=@sifre,adi=@adi,soyadi=@soyadi,eposta=@eposta where ID=@ID",conn);

                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = K.ID;
                cmd.Parameters.Add("@kullaniciadi", SqlDbType.NVarChar).Value = K.kullaniciadi;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = K.sifre;
                cmd.Parameters.Add("@adi", SqlDbType.NVarChar).Value = K.adi;
                cmd.Parameters.Add("@soyadi", SqlDbType.NVarChar).Value = K.soyadi;
                cmd.Parameters.Add("@eposta", SqlDbType.NVarChar).Value = K.eposta;
                baglantiayari();
                returnvalues = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                baglantiayari();
            }
            return returnvalues;

        }

        public int sifredegistir(EntitiesKull K)
        {
            try
            {
                cmd = new SqlCommand(@"update Kullanicilar set sifre=@sifre where ID=@ID", conn);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = K.ID;
                cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = K.sifre;
                baglantiayari();
                returnvalues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                baglantiayari();
            }
            return returnvalues;
        }



        public int kysil(Guid ID)
        {
            try
            {
                cmd = new SqlCommand(@"delete Kullanicilar where ID=@ID", conn);

                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = ID;
                baglantiayari();
                returnvalues = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {


            }
            finally
            {
                baglantiayari();
            }
            return returnvalues;


        }

        //Kullanıcıları Listeler
        public SqlDataReader kytlistele()
        {
            cmd = new SqlCommand("select * from Kullanicilar",conn);
            baglantiayari();
            return cmd.ExecuteReader();

        }

        //Yetkili kullanıcıları Listeler
        public SqlDataReader kytyetkililistele()
        {
            cmd = new SqlCommand("select * from yetkiler", conn);
            baglantiayari();
            return cmd.ExecuteReader();
        }

        //public SqlDataReader kytListeID(Guid ID)
        //{
        //    cmd = new SqlCommand("select * from Kullanicilar where ID=@ID", conn);
        //    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = ID;
        //    baglantiayari();
        //    return cmd.ExecuteReader();

        //}





    }
}
