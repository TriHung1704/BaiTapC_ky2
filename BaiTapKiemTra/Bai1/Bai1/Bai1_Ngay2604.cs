using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a222 = Int32.Parse(Console.ReadLine());
            double b222 = Int32.Parse(Console.ReadLine());
            double c222 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a222, b222, c222);

            double delta = pt.delta(a222, b222, c222);
            int check222 = pt.nghiem(delta);
            if (check222 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check222 == 0)
            {
                double x = -b222 / (2 * a222);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b222 - Math.Sqrt(delta)) / (2 * a222);
                double x2 = (-b222 + Math.Sqrt(delta)) / (2 * a222);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
                Console.ReadKey();
            }
        }
    }
   
    class ptb2
    {
        private double a222;
        private double b222;
        private double c222;

        public ptb2()
        {
        }

        public ptb2(double a222, double b222, double c222)
        {
            A = a222;
            B = b222;
            C = c222;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a222, double b222, double c222)
        {
            return b222 * b222 - 4 * a222 * c222;
        }

        public int nghiem(double delta222)
        {
            if (delta222 < 0)
            {
                return -1;
            }
            else if (delta222 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}