using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LinearEquation
{
    class Program
    {
        /*
         * Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью 
         * полей вещественного типа. Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
         * Осуществить использование экземпляра в программе.
         */
        static void Main(string[] args)
        {
            #region Блок ввода данных
            Console.WriteLine("Решение линейного уравнения вида k*X + b = 0");
            Console.Write($"Введите коэффициент k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            #endregion
            LinearEquation firstLinEq = new LinearEquation(); //экзмепляр структуры и инициализация
            Console.WriteLine($"X={firstLinEq.Root(k, b):f3}");
            Console.ReadKey();
        }

        struct LinearEquation
        {
            double factorK, factorB;

            public double K
            {
                set
                {
                    if (value == 0)
                    {
                        factorK = 1;
                        Console.WriteLine("Множитель К не должен быть равен 0. Присвоено значение 1");
                    }
                    else
                        factorK = value;
                }
                get { return factorK; }
            }
            public double B 
            {
                get { return factorB; } 
                set { factorB = value; } 
            }

            public double Root(double k, double b)
            {
                K = k; B = b;
                return -factorB / factorK; //Возрат решения x=-b/k
            }
        }
    }
}
