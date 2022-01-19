using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Vectors3D : Vectors2D
    {
        private double Z;

        public Vectors3D() : base()
        {
            this.Z = 0;
        }
        public Vectors3D(double X, double Y, int nb, double Z) : base(X, Y, nb)
        {
            this.Z = Z;
        }

        public Vectors3D(Vectors3D v)
        {
            absissaX = v.absissaX;
            ordinateY = v.ordinateY;
            number = v.number;
            Z = v.Z;
        }

        public void setZ(float z)
        {
            this.Z = z;
        }

        public double getZ()
        {
            return Z;
        }

        public override string ToString()
        {
            return "X = " + absissaX + " - Y = " + ordinateY + " - Z = " + Z;
        }

        public override bool Equals()
        {
            if (absissaX == ordinateY && absissaX == Z && ordinateY == Z)
            {
                return true;
            }
            return false;
        }

        public override double computeNorm()
        {
            double norm = 0;
            return norm = Math.Sqrt(Math.Pow(absissaX, 2) + Math.Pow(ordinateY, 2) + Math.Pow(Z, 2));
        }
    }
}
