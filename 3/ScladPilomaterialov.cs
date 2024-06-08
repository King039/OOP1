using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class ScladPilomaterialov
    {
        private double sklad;
        private string fio;
        private double maxVolum;
        private double current;

        public double Sklad
        {
            get { return sklad; }
            set { sklad = value; }
        }
        public double MaxVolum
        {
            get { return maxVolum; }
            set { maxVolum = value; }
        }
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }
        public void ColMaterials()
        {
            return maxVolum - current;
        }
    }
}
