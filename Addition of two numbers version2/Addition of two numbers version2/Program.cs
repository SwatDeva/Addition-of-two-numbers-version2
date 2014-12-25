using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_two_numbers_version2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("The sum of two numbers is " + calculator.addTwoNumbers(3, 5));

        }
    }
}
