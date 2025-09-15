using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgovIV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.DolgovIV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма эл-тов массива = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Разница эл-тов массива = " + DataService.SubstractionArray(numsArray));

            Console.WriteLine("Произведение эл-тов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
