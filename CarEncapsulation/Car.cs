using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEncapsulation
{
    internal class Car
    {
        // kapıyı kapsüllüyoruz.
        private int _kapi;// private field for encapsulation
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        // public properties
        public int Kapi {
            get { return _kapi; }
            set

            {
                if (value != 2 && value != 4)
                {
                    Console.WriteLine("kapı sayısı 2 veya 4 olabilir");
                    _kapi = -1;
                }
                else { 
                    _kapi = value;
                }
            } }

        public Car(string marka, string model,string renk,int kapi)
        {
            Marka = marka;
            Model= model;
            Renk = renk;
            Kapi = kapi;
        }

        public void Info()
        {
            Console.WriteLine("Arabanın markası :"+Marka+", modeli:"+ Model+", rengi: "+ Renk+ ", kapı sayısı:"+ Kapi);
        }

    }
}
