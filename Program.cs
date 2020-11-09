using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_MSP
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, s;  

            Console.WriteLine("---------------------Программа возведение в степень-----------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("Введите a");
            s = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            a = Convert.ToDouble(Console.ReadLine());

            s = System.Math.Pow(s, a);    
            Console.WriteLine("Степень = " + s);    
            

            Console.Read();   

        }
    }
}
