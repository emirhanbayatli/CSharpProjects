using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();

            Console.WriteLine("Welcome to app!");
            Console.Write("Enter your Id:");
            employee.IDNO = Console.ReadLine();

            Console.WriteLine("Employee Id = " + employee.IDNO);

            Console.ReadLine();

        }
    }
}
