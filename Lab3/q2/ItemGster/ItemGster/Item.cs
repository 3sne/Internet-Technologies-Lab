using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGster
{
    class Item
    {
        public string name{ get; set; }
        float cost;
        float gst;
        public float Gst
        {
            get
            {
                return this.gst;
            }
            set
            {
                this.gst = value;
            }
        }
        public float Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value > 0)
                {
                    this.cost = value;
                    this.gst = CalcGst();
                }
            }
        }

        public float CalcGst()
        {
            return this.cost * 0.08F;
        }

    }
}
