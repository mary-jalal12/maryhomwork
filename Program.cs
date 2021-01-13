using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bday = Convert.ToDateTime("1/2/2001");
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age))
                age--;
            Console.WriteLine(age);
            Console.ReadLine();
 




        }
    }
}
