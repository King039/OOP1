using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Auto
    {
        private string name;
        private double volume;
        private double expend;
        private double curent;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Volume
        {
            get { return volume; }
            private set { if(value > 0) volume = value; }
        }
        public double Expend
        {
            get { return expend; }
            set { if (value > 0) expend = value; }
        }
        public double Curent
        {
            get { return curent; }
            set
            {
                if (value > volume - curent)
                {
                    Console.Write("Перелил");
                    curent = volume;
                }
                else curent += value;
            }
        }
        public void Fide(double fide)
        {
            Curent = fide;
        }
        public double Way(double km)
        {
            return km * expend / 100;
        }
        public double Remains()
        {
            return (curent / expend) * 100;
        }

        public Auto(string name, double volume, double expend, double curent)
        {
            Name = name;
            Volume = volume;
            Expend = expend;
            Curent = curent;
        }
    }
}
