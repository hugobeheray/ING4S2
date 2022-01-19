using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Vectors2D
    {
        protected double absissaX;
        protected double ordinateY;
        protected int number;


        public Vectors2D()
        {
            this.absissaX = 0;
            this.ordinateY = 0;
            this.number = 0;
        }
        public Vectors2D(double X, double Y, int nb)
        {
            this.absissaX = X;
            this.ordinateY = Y;
            this.number = nb;
        }

        public Vectors2D(Vectors2D v)
        {
            absissaX = v.absissaX;
            ordinateY = v.ordinateY;
            number = v.number;
        }

        public double getX()
        {
            return absissaX;
        }

        public double getY()
        {
            return ordinateY;
        }

        public int getNumber()
        {
            return number;
        }

        public void setX(float x)
        {
            this.absissaX = x;
        }

        public void setY(float y)
        {
            this.ordinateY = y;
        }

        public void setNumber(int n)
        {
            this.number = n;
        }

        public override string ToString()
        {
            return "X = " + absissaX + " - Y = " + ordinateY;
        }

        public virtual bool Equals()
        {
            if (absissaX == ordinateY)
            {
                return true;
            }
            return false;
        }

        public virtual double computeNorm()
        {
            double norm = 0;
            return norm = Math.Sqrt(Math.Pow(absissaX, 2) + Math.Pow(ordinateY, 2));
        }

    }
}