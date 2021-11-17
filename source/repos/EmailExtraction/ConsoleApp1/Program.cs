using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string emails = "";
            string path = @"C:\Corndel\Bootcamp\Regex\EmailExtraction\emailList.txt";
            string text = File.ReadAllText(path);

            Regex emailRegex = new Regex(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)");
            MatchCollection emailMatches = emailRegex.Matches(text);

          
            for (int count = 0; count < emailMatches.Count; count++)
            {
                emails = emails + ", " + emailMatches[count].Value;
            }
            Console.WriteLine("~~~ FETCHED EMAILS ~~~ \n");
            Console.WriteLine(emails);
            Console.ReadLine();

        }
    }
}

