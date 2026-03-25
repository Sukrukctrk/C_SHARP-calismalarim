using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    public class calisan
    {
        public string ad_soyad;
        public int telefon;
        public string email;


        public  calisan(String ad_soyad,String email,int telefon) 
        {
            this.ad_soyad = ad_soyad;
            this.telefon = telefon;
            this.email = email;

        }

        public void giriş()
        {
            Console.WriteLine("giriş yapıldı");
        }


        public void çıkış()
        {
            Console.WriteLine("çıkış yapıldı");
        }

        public void yemek()
        {
            Console.WriteLine("yemek yapıldı");
        }

        public void Setad_soyad(String ad_soyad) {
        
            this.ad_soyad= ad_soyad;
        }

        public string getad_soyad()
        {
            return ad_soyad ;
        }

        public void Settelefon(int telefon)
        {

            this.telefon=telefon;
        }

        public int gettelefon()
        {
            return telefon;
        }


        public void Setemail(String email)
        {

            this.email = email;
        }

        public string getemail()
        {
            return email;
        }


    }
}
