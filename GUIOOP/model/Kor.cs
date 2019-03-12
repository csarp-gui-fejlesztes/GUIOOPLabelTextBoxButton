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
            if (sugar <= 0)
                throw new KornekRosszASugaraException("Körnek rossz a sugara!");
            this.sugar=sugar;
        }
        public void setSugar(double sugar)
        {
            if (sugar <= 0)
                throw new KornekRosszASugaraException("Körnek rossz a sugara!");
            this.sugar = sugar;
        }
        public double getKerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public double getTerulet()
        {
            return sugar * sugar * Math.PI;
        }



    }
}
