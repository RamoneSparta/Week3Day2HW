using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3Day2HW;

namespace Week3Day2HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparison comparison = new Comparison();
            Console.WriteLine("Hi, Please enter the first name you want to compare: ");
            var value = new Comparison();
            value.Name = Console.ReadLine();
            Console.WriteLine("Now the second name: ");
            var value1 = new Comparison();
            value.Name1 = Console.ReadLine();
            value.GetLengthComparison();
            value.GetNameComparison(value1);
            Console.ReadLine();

        }

    }
}
