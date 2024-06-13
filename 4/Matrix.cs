using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Matrix
    {
        private int[,]? mas;

        public Matrix(int[,]? mas)
        {
            this.mas = mas;
        }

        public int this[int i, int j]
        {
            get => mas![i, j];
            set => mas![i, j] = value;
        }
    }
}
