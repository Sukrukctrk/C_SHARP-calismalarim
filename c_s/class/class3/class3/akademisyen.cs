using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class akademisyen : calisan
    {

        public String bolum;
        public String gorev;
        public String dersler;

        public akademisyen(String ad_soyad, String email, int telefon, String bolum, String gorev, String dersler) 
            : base(ad_soyad, email, telefon)
        {
            this.bolum = bolum;
            this.gorev = gorev;
            this.dersler = dersler;
        }


        public void derse_gir()
        {
            Console.WriteLine("derse giriş yapıldı");
        }
    }
}
