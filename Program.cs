using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice
{
    class Program
    {
        const string STRING_FOR_EX1 = "ABCDEFG";
        const int POINT_A = 1;
        const int LENGHT = 4;
        static void Main(string[] args)
        {
            string excesise1 = FisrtExcesise.Run(STRING_FOR_EX1, POINT_A, LENGHT);
            Console.WriteLine(excesise1);
            string excesise2 = SecondExcesise.Run();
            Console.WriteLine(excesise2);
        }
    }
}
