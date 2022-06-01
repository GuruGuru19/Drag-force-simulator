using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DargSim1
{
    class Trajectory
    {
        const double p = 1.2;// air density at sea level is 1.2 (mg/m^3)
        const double Cd = 0.47;// a sphere drag coefficient is 0.47 (~)
        const double g = 9.81;// g gravitational acceleration (m/s^2)

        const double f = 1;//draw # points per sec (hrz)

        List<Point> points;
        private double dt;

        /// <summary>
        /// makes a Trajectory by the initial conditions
        /// </summary>
        /// <param name="ballDiameter">the ball's diameter in m</param>
        /// <param name="ballMass">the ball's mass in kg</param>
        /// <param name="a0">initial angle in deg</param>
        /// <param name="v0">initial velocity in m/s</param>
        /// <param name="y0">initial hight in m</param>
        /// <param name="maxT"> max time of the simulation </param>
        public Trajectory(double ballDiameter, double ballMass, double a0, double v0, double y0, double maxT, double dt)
        {
            double mu = 0.5 * p * Cd * Math.PI * Math.Pow(ballDiameter/2,2);// the constant part of the drag equation
            double a0r = (Math.PI / 180) * a0;//transfers the angle from deg to rad
            this.dt = dt;// saves the dt for later use on the object

            this.points = new List<Point>();//builds an empety list on points

            double x = 0, y = y0;//sets the x and y and vx and xy... 
            double vx = Math.Cos(a0r) * v0, vy = Math.Sin(a0r) * v0;
            double ax, ay;
            double t = 0;
            while (t <= maxT && y > 0)
            {
                points.Add(new Point(x, y, vx, vy));// adds a new point to the list
                x += vx * dt;
                y += vy * dt;
                ax = -(vx * vx * mu / ballMass);
                ay = -(vy * vy * mu / ballMass) - g;
                vx += ax * dt;
                vy += ay * dt;
                t += dt;
            }
        }

        public bool DrawTrajectory(System.Windows.Forms.DataVisualization.Charting.DataPointCollection dataPoints)
        {
            double t = 0;
            foreach (Point p in this.points)
            {
                dataPoints.AddXY(p.GetX(), p.GetY());
                t += this.dt;
                if ( ((int) (t*f)) == (t * f))
                {
                    Thread.Sleep((int)(1000/f));
                }
            }
            return true;
        }
    }
}
