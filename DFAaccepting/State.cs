using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFAaccepting
{
    class State
    {
        public string name;
        public int x;
        public int y;
        public int width = 50;
        private double distancefromcenter(int x1, int y1)//computes a points distance from center of this state
        {
            return (double) Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));
        }
        public bool isonit(int x1,int y1)//computes if a point is on this state or not
        {
            if (distancefromcenter(x1, y1) <= width/2)
                return true;
            else
                return false;
        }
    }
}
