using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class Memur : calisan
    {
        public String departman;
        public String mesai;

        public Memur(String ad_soyad, String email, int telefon, String departman, String mesai)
            : base(ad_soyad, email, telefon) {
        
        
        
        this.departman = departman;
        this.mesai = mesai;        
        }

        public void calıs()
        {
            Console.WriteLine("çalışıyor");
        }

       
            
    }
}
