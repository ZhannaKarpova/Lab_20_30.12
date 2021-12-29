using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_30._12
{
    class Program
    
        {
            static void Main(string[] args)

            {
                Console.Write("Введите радиус:");
                double R = Convert.ToDouble(Console.ReadLine());

                Func<double, double> func = Method;
                if (func != null)
                {
                    double r = func(R);
                    Console.WriteLine(r);
                }

                Func<double, double> func1 = new Func<double, double>(Method2);
                func1?.Invoke(R);
                double r1 = func1(R);
                Console.WriteLine(r1);

                Func<double, double> func2 = new Func<double, double>(Method3);
                func2?.Invoke(R);
                double r2 = func2(R);
                Console.WriteLine(r2);
                Console.ReadKey();
            }
            static double Method(double R)
            {
                double D = 2 * Math.PI * R;
                return D;
            }
            static double Method2(double R)
            {
                double S = Math.PI * Math.Pow(R, 2);
                return S;
            }
            static double Method3(double R)
            {
                double V = (4 * (Math.PI * Math.Pow(R, 3))) / 3;
                return V;
            }
        }
    }

