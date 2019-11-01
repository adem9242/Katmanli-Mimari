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
    public partial class Form1 : Form
    {
        public static string gelen, kadi,psw;
        BusinesLojikLayer.BLL bll;
        
        
        
        public Form1()
        {
            InitializeComponent();
            
            bll = new BusinesLojikLayer.BLL();

            
            
        }
        
        public   void temizle()
        {
            txt_kullaniciadi.Clear();
            txt_sifre.Clear();

        }
        int hakyonetici = 3;
        int hakkullanici = 3;

      /*  public void uckezsifrekontolu()
        {
            hak--;
            if (hakkulanici ==3)
            {
                temizle();
             string bilgi=   MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.3 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                bilgi = label3.Text;
            }
            else if (hakkulanici ==2)
            {
                temizle();
                MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.2 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();

            }
            else if (hakkulanici ==1)
            {
                temizle();
                MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.son kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
            }
            else if (hakkulanici ==0)
            {
                temizle();
                MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.Üzgünüm kullanıcı adı veya şifrenizi 3 kez yanlış girdiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("HATAAAA");
            }
        }*/



        private void button1_Click(object sender, EventArgs e)
        {





            gelen = txt_kullaniciadi.Text;
            kadi = txt_kullaniciadi.Text;
            psw = txt_sifre.Text;
            int returnvalues = bll.SistemKntrol(txt_kullaniciadi.Text, txt_sifre.Text);
            int returnnormalgiris = bll.SistemKntrol(txt_kullaniciadi.Text, txt_sifre.Text);
            if (returnvalues > 0)
            {
                temizle();
                SistemYöneticiFormu syf = new SistemYöneticiFormu();
               
                syf.Show();
                




            }
            
           
            else 
            {
                hakyonetici--;
                if (hakyonetici == 3)
                {
                    temizle();
                      MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.3 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    
                }
                else if (hakyonetici == 2)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.2 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    label3.Text = "Kullanıcı Adı veya Şifre Hatalı";
                    label3.ForeColor = Color.Red;
                }
                else if (hakyonetici == 1)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.son kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                }
                else if (hakyonetici == 0)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.Üzgünüm kullanıcı adı veya şifrenizi 3 kez yanlış girdiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("HATAAAA");
                }

                
            }
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
          






            kadi = txt_kullaniciadi.Text;
            psw = txt_sifre.Text;
            int returnvalues = bll.yoneticikntrol(txt_kullaniciadi.Text, txt_sifre.Text);

            if (returnvalues > 0)
            {

                temizle();
                Anaform anf = new Anaform();
                anf.Show();




            }


            else 
            {
                hakkullanici--;
                if (hakkullanici==3)
                {
                    temizle();
                    string bilgi = MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.3 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    bilgi = label3.Text;
                }
                else if (hakkullanici==2)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.2 kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    label3.Text = "Kullanıcı Adı veya Şifre Hatalı";
                    label3.ForeColor = Color.Red;
                }
                else if (hakkullanici==1)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.son kez yanlış girmeniz halinde program kapanacaktır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                }
                else if (hakkullanici==0)
                {
                    temizle();
                    MessageBox.Show("Kullanici Adı veya Şifre Hatalıdır.Üzgünüm kullanıcı adı veya şifrenizi 3 kez yanlış girdiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("HATAAAA");
                }


            }

            
            

        }

        
    }
}
