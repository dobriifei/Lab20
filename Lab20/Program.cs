using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program

    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Length;
            myDelegate += Square;
            myDelegate += Volume;
            myDelegate(3.1);
            Console.ReadKey();
        }

        static double Length(double R)
        {
            double D = Math.PI * (R) * 2;
            Console.WriteLine(D);
            return D;
        }
        static double Square(double R)
        {
            double S = Math.PI * (R) * R;
            Console.WriteLine(S);
            return S;
        }
        static double Volume(double R)
        {
            double V = 4 / 3 * Math.PI * R * R * R;
            Console.WriteLine(V);
            return V;
        }
    }
}
