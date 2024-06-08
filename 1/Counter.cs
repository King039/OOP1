using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Counter
    {
        private int count;
        private int max, min;
        public int Count
        {
            get { return count; }
            set { if(value <= max && value >= min) this.count = value; }
        }

        public Counter()
        {
            this.min = -10;
            this.max = 10;
            this.Count = 0;
        }

        public Counter(int c, int min, int max)
        {
            this.max = max;
            this.min = min;
            Count = c;
        }

        public void inc()
        {
            this.Count++;
        }

        public void dec()
        {
            this.Count--;
        }
    }
}
