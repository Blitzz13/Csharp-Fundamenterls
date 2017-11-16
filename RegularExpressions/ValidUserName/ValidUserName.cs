using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUserName
{
    class ValidUserName
    {
        static void Main(string[] args)
        {
            var userNames = Console.ReadLine()
                .Split(new [] {' ', '\\', '/', '(', ')'},StringSplitOptions.RemoveEmptyEntries)
                .Where(a => Regex.IsMatch(a, @"\b[a-zA-Z]\w{2,24}\b")).ToArray();

            int bestLenghtSum = 0;
            string bestFirstUser = null;
            string bestSecondUser = null;
            for (int i = 0; i < userNames.Length - 1; i++)
            {
                string firstUser = userNames[i];
                string nextUser = userNames[i + 1];
                int currentLenght = firstUser.Length + nextUser.Length;
                if (currentLenght > bestLenghtSum)
                {
                    bestFirstUser = firstUser;
                    bestSecondUser = nextUser;
                    bestLenghtSum = currentLenght;
                }
            }

            Console.WriteLine(bestFirstUser);
            Console.WriteLine(bestSecondUser);
        }
    }
}
