using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTester
{
    class Delay
    {
        private int amount;
        private int index;

        public Delay(int amount, int index)
        {
            this.amount = amount;
            this.index = index;
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
    }
}
