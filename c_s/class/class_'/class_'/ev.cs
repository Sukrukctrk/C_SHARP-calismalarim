using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    public class ev
    {
        private String rebk;
        private String boya;
        private int kat;


        public ev(String rebk , string boya, int kat)
        {
             this.rebk = "mavi";
            this.boya = "kırmızı";
            this.kat = 3;
             
        }


        public ev()
        {


        }

        public void bilgileri_göster()
        {
            Console.WriteLine(getRebk());
            Console.WriteLine(this.rebk);


        }
        public String getRebk(){ 
            return rebk;

        
  
        }

        public void SetRebk(String rebk)
        {
            this.rebk = rebk;
        }





        

    }
}
