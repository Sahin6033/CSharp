using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcAvg(100, 60, 50, 80, 90, 70, 80, 50, 90, 40, 70, 30, 70);
        }
        public static void CalcAvg(params int[] grades)
        {
            double sumOfGrades = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sumOfGrades+=grades[i];
            }
            double avg = sumOfGrades/grades.Length;
            if (avg > 60)
            {
                Console.WriteLine("Məzun oldunuz ;)");
            }
            else
            {
                Console.WriteLine("Məzun ola bilmədiniz :(");
            }
        }
    }
}
