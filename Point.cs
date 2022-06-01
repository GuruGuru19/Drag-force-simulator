using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DargSim1
{
    class Point
    {
        private double x;
        private double y;

        private double vx;
        private double vy;

        public Point(double x, double y, double vx, double vy)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public double GetVX()
        {
            return this.vx;
        }

        public double GetVY()
        {
            return this.vy;
        }

        public double GetAngle()
        {
            if (this.vx == 0)
            {
                if (this.vy<0)
                {
                    return 270;
                }
                else if (this.vy>0)
                {
                    return 90;
                }
                else
                {
                    return 0;
                }
            }
            return Math.Atan(this.vy / this.vx);
        }
    }
}
