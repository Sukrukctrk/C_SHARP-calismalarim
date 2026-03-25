using class2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__
{
    internal class Program
    {
        static void Main(string[] args)

        {
            ev ev1 = new ev();
            ev1.SetRebk("yeşil");
            Console.WriteLine(ev1.getRebk());

            ev1.bilgileri_göster();
        }
    }
}
