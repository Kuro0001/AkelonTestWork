using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkelonTestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            SumCount work = new SumCount();
            Console.WriteLine(work.Distribute(10000, "1000;2000;3000;5000;8000;5000", DistributionType.proportional));  //Выход: 416.67;833.33;1250;2083.33;3333.33;2083.34
            Console.WriteLine(work.Distribute(10000, "1000;2000;3000;5000;8000;5000", DistributionType.first_count));  //Выход: 1000;2000;3000;4000;0;0
            Console.WriteLine(work.Distribute(10000, "1000;2000;3000;5000;8000;5000", DistributionType.last_count));  //Выход: 0;0;0;0;5000;5000
            Console.ReadKey();
            /*
            Console.WriteLine("tests for proportional method");
            Console.WriteLine(work.Distribute(10000, "3333;3333;3333", DistributionType.proportional));  //Выход: 3333,33;3333,33;3333,33
            Console.WriteLine(work.Distribute(10000, "3333,33;3333;3333", DistributionType.proportional));  //Выход: 3333,55;3333,22;3333,22
            Console.WriteLine(work.Distribute(10000, "1;1;1", DistributionType.proportional));  //Выход: 3333,33;3333,33;3333,33
            Console.WriteLine(work.Distribute(10000, "0;0;1", DistributionType.proportional));  //Выход: 0;0;10000
            Console.ReadKey();
            Console.WriteLine("tests for count method");
            Console.WriteLine(work.Distribute(10000, "1000;1000;1000;1000;1000;1000", DistributionType.first_count));  //Выход: 1000;1000;1000;1000;1000;1000
            Console.WriteLine(work.Distribute(10000, "10000;1000;1000;1000;1000;1000", DistributionType.first_count));  //Выход: 10000;0;0;0;0;0
            Console.WriteLine(work.Distribute(10000, "100000;1000;1000;1000;1000;1000", DistributionType.first_count));  //Выход: 10000;0;0;0;0;0
            Console.WriteLine(work.Distribute(10000, "0;0;0;0;0;0", DistributionType.first_count));  //Выход: 0;0;0;0;0;0
            Console.ReadKey();
            */
        }
    }
}
