using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //string tekst = File.ReadAllLines(@"C: \Users\Kasutaja\Downloads\kttekst";
            string[] lines = File.ReadAllLines(path:@"C: \Users\Kasutaja\Downloads\kttekst.txt");
            int i = 0;

            foreach (string line in lines)
            {

                i++;
                
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
