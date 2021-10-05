using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Summ = 0;
            Console.WriteLine("Введите число элементов массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] Mss = new int[a];
            Console.WriteLine("Введите значение элементов массива числами:");
            for (int j = 0; j < a; j++)
            {
                Mss[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            Summ = Summ + Mss[j];
            double Sred = Summ / a;
            Console.WriteLine("Среднее значение равно {0}", Sred);
            Console.ReadKey();
        }
    }
}
