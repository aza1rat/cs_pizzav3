using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogookno
{
     public class Pizza
     {
        public string name;
        public double price;
        double kkal;
        double weight;
        string description;
        string image;
        public int count;

        

        public Pizza (string nam, double pr, double kk, double wgt, string desc, string img)
        {
            name = nam;
            price = pr;
            kkal = kk;
            weight = wgt;
            description = desc;
            image = img;
            count = 1;
        }

        public override string ToString()
        {
            return name;
        }
    }

    
}
