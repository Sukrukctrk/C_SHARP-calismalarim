using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Araba
    {
        private string marka;
        private string model;
        private int yil;
        private string renk;
        private int hiz;


        public Araba(string marka, string model, int yil, string renk)
        {
            this.marka = marka;
            this.model = model;
            this.yil = yil;
            this.renk = renk;
            this.hiz = 0;

            // Constructor to initialize the car's properties
        }

        public void bilgiYazdir()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Yıl: {yil}, Renk: {renk}, Hız: {hiz}");
            // Method to print the car's information
        }

    }
    }
