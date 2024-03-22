using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNORBIT
{
    class Program
    { 
        static void Main(string[] args)
        {
            IndexCalculation indexCalculation = new IndexCalculation();
            indexCalculation.InputData();

            Console.WriteLine("Нажмите на любую клавишу, чтобы выйти из программы");
            Console.ReadLine();
        }
    }
}
