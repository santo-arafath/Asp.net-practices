using BusinessLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;

            Console.Write("Enter Id :");
            id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("User : " + PersonService.GetName(id));

            Console.ReadKey();

            

        }
    }
}
