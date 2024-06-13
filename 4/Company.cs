using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Company
    {
        private Person[]? personal;
        public Person[]? Personal
        {
            get => personal; 
            set => personal = value;
        }

        public Person this[int index]
        {
            get => personal![index];
            set => personal![index] = value;
        }
    }
}
