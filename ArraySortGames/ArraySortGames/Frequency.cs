using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortGames
{
    public class Frequency
    {
        public Frequency()
        {
            this.count = 1;
        }

        private int count;

        public int getFrequency()
        {
            return this.count;
        }

        public void incrementFrequency()
        {
            this.count++;
        }

        public void setCount(int count)
        {
            this.count = count;
        }
    }
}
