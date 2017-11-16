using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var dateModifier = new DateModifier();

            Console.WriteLine(dateModifier.CalculateDifferenceBetweenDates(firstDate, secondDate));
            
        }
    }
}
