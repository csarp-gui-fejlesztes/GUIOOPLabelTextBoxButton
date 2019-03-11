using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIOOP.model
{
    class Kor
    {
        private double sugar;

        public Kor(double sugar)
        {
            this.sugar = sugar;
        }
        public void setSugar(double sugar)
        {
            this.sugar = sugar;
        }

        public double getKerulet()
        {
            return 2 * sugar * Math.PI;
        }
    }
}
