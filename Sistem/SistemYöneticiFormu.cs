using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem
{
    public partial class SistemYöneticiFormu : Form
    {
        public static string gelen;
        
       // public static Guid gelenID;
        public SistemYöneticiFormu()
        {
            InitializeComponent();
            kullanicilarlistele();
            yetkilikullanicilist();

            
        }
        public void sis_yon_temizle()
        {
            txt_skullaniciadi.Clear();
            txt_ssifre.Clear();
            txt_sadi.Clear();
            txt_ssoyadi.Clear();
            txt_seposta.Clear();
            
        }

        //kullanicları listeler
        public void kullanicilarlistele()
        {
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            List<Entities.EntitiesKull> listeler = bll.kayitlst();
            if (listeler != null && listeler.Count > 0)
            {
                y_lst_kullanicilar.DataSource = listeler;

            }

        }

        //yetkili kullanıcları listeler
        public void yetkilikullanicilist()
        {
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            List<Entities.EntitiesKull> yetlisteler = bll.yetkilikulllistele();
            if (yetlisteler != null && yetlisteler.Count > 0)
            {
                y_lst_yoneticiler.DataSource = yetlisteler;

            }
        }






        private void btn_skullaniciekle_Click(object sender, EventArgs e)
        {
            
            
           
            
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            int  returnvalues=bll.kayiTekle(txt_skullaniciadi.Text, txt_ssifre.Text, txt_sadi.Text, txt_ssoyadi.Text, txt_seposta.Text); 
            if(returnvalues>0)
            {
                
                kullanicilarlistele();
               
                
                MessageBox.Show("Kaydınız Eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }

            else
            {
                
                MessageBox.Show("KullaniciAdi ve Şifre Kısmı Boş Geçilemez.Lütfen doldurun.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sis_yon_temizle();

        }

        private void btn_sguncelle_Click(object sender, EventArgs e)
        {
            
            Guid ID = ((EntitiesKull)y_lst_kullanicilar.SelectedItem).ID;
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            
            int returnvalues = bll.kayiTduzenle(ID, txt_skullaniciadi.Text, txt_ssifre.Text, txt_sadi.Text, txt_ssoyadi.Text, txt_seposta.Text);
            if (returnvalues > 0)
            {
                if(!string.IsNullOrEmpty(txt_skullaniciadi.Text))
                {
                    kullanicilarlistele();
                    MessageBox.Show("Kaydınız Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sis_yon_temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme yapmak için kullanıcılar listesine çift tıklayarak seçim yapınız","HATA",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Kaydınız Güncellenemedi.Lütfen Tekrar deneyiniz.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btn_skullanicisil_Click(object sender, EventArgs e)
        {
            
            Guid ID = ((Entities.EntitiesKull)y_lst_kullanicilar.SelectedItem).ID;
            string kullaniciadigelen = ((Entities.EntitiesKull)y_lst_kullanicilar.SelectedItem).kullaniciadi;

            // int iss= y_lst_yoneticiler.FindStringExact(kullaniciadigelen);
            //if (iss<0)
            //{
            //    MessageBox.Show("Test");
            //}

            //for (int i = 0; i < y_lst_yoneticiler.Items.Count; i++)
            //{
            //    bool al = y_lst_yoneticiler.Items[i].ToString().ToLower().Contains(kullaniciadigelen);
                



            //}
            

           
            



            








            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
                    DialogResult secenek = MessageBox.Show("Seçmiş olduğunuz kullanıcı silinecektir.Kullanıcıyı silmek istiyor musunuz?", "Karar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    int returnvalues = bll.kayiTsil(ID);

                //kullnicilardasecilenlist =returnvalues;
                if (returnvalues > 0 && secenek == DialogResult.Yes)
                {



                    sis_yon_temizle();
                    kullanicilarlistele();
                    MessageBox.Show("Kaydınız Silinmiştir");
                }
                else if (secenek == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Silinmedi hata");

                }

            




        }

        private void y_lst_kullanicilar_DoubleClick(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            Entities.EntitiesKull secilikayit = (Entities.EntitiesKull)lst.SelectedItem;
            if(secilikayit!=null)
            {
                txt_skullaniciadi.Text = secilikayit.kullaniciadi;
                txt_ssifre.Text = secilikayit.sifre;
                txt_sadi.Text = secilikayit.adi;
                txt_ssoyadi.Text = secilikayit.soyadi;
                txt_seposta.Text = secilikayit.eposta;
                
            }
        }

        private void btn_syetkiver_Click(object sender, EventArgs e)
        {
            string kullaniciadi = ((Entities.EntitiesKull)y_lst_kullanicilar.SelectedItem).kullaniciadi ;
            string sifre = ((Entities.EntitiesKull)y_lst_kullanicilar.SelectedItem).sifre;


            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            DialogResult secim = MessageBox.Show("Bu kullanıcıya Yetki vermek üzeresiniz.Yetki verilsin mi?", "Yetki Verme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            
            if (secim == DialogResult.Yes)
            {



                int returnvalues = bll.kayiTYetkiver(kullaniciadi,sifre);
                if (returnvalues > 0)
                {

                    yetkilikullanicilist();

                    MessageBox.Show("Kullanıcıya Yetki Verildi","Yetki Hakkında",MessageBoxButtons.OK);
                    sis_yon_temizle();


                }
            }
            else
            {
                MessageBox.Show("Hata Yetki verilemedi.");
            }
        }

        //yetkiyi kaldırmak için 
        private void y_lst_yoneticiler_DoubleClick(object sender, EventArgs e)
        {
           
            Guid ID = ((Entities.EntitiesKull)y_lst_yoneticiler.SelectedItem).ID;
            string isimkull = ((Entities.EntitiesKull)y_lst_yoneticiler.SelectedItem).kullaniciadi;
            // gelenID =ID;
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            DialogResult secenek = MessageBox.Show("Seçmiş olduğunuz kullanıcı yetkisini kaldırmak üzeresiniz.Kullanıcı Yetkisini kaldırmak istiyor musunuz?", "Karar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (label7.Text ==isimkull)
            {
                MessageBox.Show("Sistem yöneticisi olduğunuz için yetkinizi kaldıramazsınız");
            }
            else
            {





                int returnvalues = bll.yetkikaldir(ID);

                if (returnvalues > 0 && secenek == DialogResult.Yes)
                {



                    yetkilikullanicilist();
                    MessageBox.Show("Kullanıcı Yetkisi Kaldırılmıştır ");







                }
                else if (secenek == DialogResult.No)
                {

                }
                else
                {
                    MessageBox.Show("Silinmedi hata");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
            
        }

        private void SistemYöneticiFormu_Load(object sender, EventArgs e)
        {

            string ID = Form1.gelen;
            label7.Text = ID;




        }
    }
}
