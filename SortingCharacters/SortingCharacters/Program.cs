using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            //string replacedString = text.Replace(" ", "");
            //Console.WriteLine("replaced string " + replacedString);
            processString(text);

        }

        public static string  processString(string text)
        {
            var result = text.ToLower().Replace(" ","").Replace(",","").Replace(".","").ToCharArray().OrderBy(x => x);
            foreach (char letter in result)
            {
                Console.Write(letter);
            }

            Console.WriteLine("");
            return result.ToString();
        }            
            
    }
}
