using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class ogretim_gor : akademisyen
    {
        public string unvan;

        public ogretim_gor(String ad_soyad, String email, int telefon, String bolum,String gorev,String dersler, String unvan) 
           :base (ad_soyad, email, telefon,bolum, gorev, dersler)
        {
            this.unvan = unvan;

        }
     
        public void derse_gir()
        {
            Console.WriteLine("derse girildi");
        }


    }
}
