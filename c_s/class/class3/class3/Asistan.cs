using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class Asistan : akademisyen

    {
        public string yuksek_e;

        public Asistan(String ad_soyad, String email, int telefon, String bolum, String gorev, String dersler, string yuksek_e):
            base(ad_soyad, email, telefon, bolum, gorev,dersler)
        {

            this.yuksek_e = yuksek_e;
        }

        public void laba_gir()
        {
            Console.WriteLine("laba girildi");
        }
    }

}
