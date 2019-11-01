using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntitiesKull
    {
        public Guid ID { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string eposta { get; set; }
        
        public override string ToString()
       {

          //  "KULLANICIADI:  {0}  ŞİFRESİ: {1}",
            return string.Format("KULLANICIADI:  {0}",kullaniciadi, sifre);

        }
    }
}
