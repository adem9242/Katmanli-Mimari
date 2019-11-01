using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Sistem
{
    public partial class Anaform : Form
    {

        //public static string gelendogru;
        


        public Anaform()
        {
            
            InitializeComponent();
            //if(SistemYöneticiFormu.kullnicilardasecilenlist>0)
            //{
            //    DialogResult secenek = MessageBox.Show("Yöneticiniz kullanıcı hesabınızı silecektir.Kullanıcıyı silmek istiyor musunuz?", "Karar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if(secenek==DialogResult.Yes)
            //    {
            //        string gelendogru = secenek.ToString();

            //    }
            //}

        }
        
        private void Anaform_Load(object sender, EventArgs e)
        {
            listedoldur();
            txt_anaform_kullaniciadi.Text = Form1.kadi;
            txt_anaform_sifre.Text = Form1.psw;
            txt_anaform_kullaniciadi.Enabled = false;
            txt_anaform_sifre.Enabled = false;


        }

        public void listedoldur()
        {
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();
            List<Entities.EntitiesKull> listeler = bll.kayitlst();
            if(listeler!=null && listeler.Count>0)
            {
                list_liste.DataSource = listeler;

            }
            else
            { }


        }

        private void btn_anaformsifredegistir_Click(object sender, EventArgs e)
        {
            //Guid  ID =SistemYöneticiFormu.gelenID;
            Guid ID = ((EntitiesKull)list_liste.SelectedItem).ID;
            BusinesLojikLayer.BLL bll = new BusinesLojikLayer.BLL();

            int returnvalues = bll.anaformsifredegistir(ID, txt_anaform_yenisifre.Text);
            if (returnvalues > 0)
            {
                if(txt_anaform_yenisifre.Text==txt_anaform_yenisifretekrar.Text)
                
                MessageBox.Show("Şifreniz Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Şifreyi tekrar giriniz aynı girmediniz ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreniz Güncellenemedi.Lütfen Tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
