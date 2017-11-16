using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ktül2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tekst = File.ReadAllLines(path:@"C: \Users\Kasutaja\Downloads\kttekst.txt");
            int i = 0;
            char[] delimiterChars = { ' ' };

            foreach (string line in tekst)
            {
                string[] words = line.Split(delimiterChars);
                foreach (string word in line)
                {

                }
                
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
