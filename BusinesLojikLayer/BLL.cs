using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLojikLayer
{
    
    public class BLL
    {
        
        DataLojikLayer.DLL dll;
        public BLL()
        {
            dll = new DataLojikLayer.DLL();
           
           
        }
        //yönetici girişi kontrol
        public int SistemKntrol(string kullaniciadi,string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                return dll.sistemkontrol(new Entities.EntitiesKull()
                {
                    kullaniciadi = kullaniciadi,
                    sifre = sifre
                });  
            } 
            return -1;
        }
        //sistem Girişi kontrol
        public int yoneticikntrol(string kullaniciadi,string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                return dll.yetkidisigiris(new Entities.EntitiesKull()
                {
                    
                    kullaniciadi = kullaniciadi,
                    sifre = sifre,



                });

            }
            else return -1;

        }
        //sisteme kullanıci ekleme
       public int kayiTekle(string kullaniciadi,string sifre,string adi,string soyadi,string eposta)
        {
            
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {


                return dll.kytekle(new Entities.EntitiesKull()
                {

                    ID = Guid.NewGuid(),
                    
                    kullaniciadi = kullaniciadi,
                    sifre = sifre,
                    adi = adi,
                    soyadi = soyadi,
                    eposta = eposta

                    
                });

                
            }
            else
                return -1;

           
        }
        //sistemden kullaniciıya yetki verme
        public int kayiTYetkiver(string kullaniciadi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {


                return dll.kytyetkiver(new Entities.EntitiesKull()
                {


                    ID = Guid.NewGuid(),

                   
                   
                 
                    kullaniciadi = kullaniciadi,
                    sifre = sifre,

                    
                   


                });



            }
            else
                return -1;


        }
        public int yetkikaldir(Guid ID)
        {
            if (ID != Guid.Empty)
            {
                return dll.yetkikaldir(ID);



            }
            else
                return -1;
        }
        public int kayiTduzenle(Guid ID, string kullaniciadi, string sifre, string adi, string soyadi, string eposta)
        {
            if (ID != Guid.Empty)
            {
                return dll.kytduzenle(new Entities.EntitiesKull()
                {
                    ID =ID,
                    kullaniciadi = kullaniciadi,
                    sifre = sifre,
                    adi = adi,
                    soyadi = soyadi,
                    eposta = eposta


                });


            }
            else
                return -1;

        }
        public int anaformsifredegistir(Guid ID, string sifre)
        {

            if (ID != Guid.Empty)
            {
                return dll.sifredegistir(new Entities.EntitiesKull()
                {
                    ID = ID,
                    
                    sifre = sifre
                    
                    
                    


                });


            }
            else
                return -1;





        }
        public int kayiTsil(Guid ID)
        {
            if (ID != Guid.Empty)
            {
                return dll.kysil(ID);
                


            }
            else
                return -1;

        }
        //Kullanicları Listele
        public List<Entities.EntitiesKull> kayitlst()
        {
            List<Entities.EntitiesKull> kayitlisteleri = new List<Entities.EntitiesKull>();
            
            try
            {
                SqlDataReader reader = dll.kytlistele();
                while(reader.Read())
                {
                    kayitlisteleri.Add(new Entities.EntitiesKull()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        kullaniciadi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        sifre = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        adi = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        soyadi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        eposta = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                    
                        
                        


                    });

                }
                reader.Close();
            }
            catch (Exception)
            {

               // throw;
            }
            finally
            {
                dll.baglantiayari();
                
            }
            return kayitlisteleri;

        }
        //Yetkili kullanıcıları listeler
        public List<Entities.EntitiesKull>yetkilikulllistele()
        {
            List<Entities.EntitiesKull> listeleyet = new List<Entities.EntitiesKull>();
            try
            {
                SqlDataReader reader = dll.kytyetkililistele();
                while(reader.Read())
                {
                    listeleyet.Add(new Entities.EntitiesKull(){

                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        kullaniciadi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        sifre = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                        




                    });

                    

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //throw;
              
            }
            finally
            {
                dll.baglantiayari();

            }
            return listeleyet;
        }




       /* public Entities.EntitiesKull kytListeID(Guid ID)
        {

            Entities.EntitiesKull kullanicikayit = new Entities.EntitiesKull();
            try
            {
                SqlDataReader reader = dll.kytListeID(ID);
                while (reader.Read())
                {
                    kullanicikayit = new Entities.EntitiesKull()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        kullaniciadi = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        sifre = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        adi = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        soyadi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        eposta = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        


                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                dll.baglantiayari();
            }
            return kullanicikayit;
        }*/













    }
}
