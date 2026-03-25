using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class Güvenlik :Memur

    {
        public String belge;

        public Güvenlik(String ad_soyad, String email, int telefon, String departman, String mesai,string belge) :
            base (ad_soyad,email,telefon,departman,mesai) {
        
           this.belge= belge;
        }


       

    }
}
