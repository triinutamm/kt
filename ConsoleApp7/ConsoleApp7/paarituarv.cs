using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv: ");
            int arv1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisestage teine arv: ");
            int arv2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nende kahe vahele jäävad paarisarvud on:");
            if (arv1 < arv2)
            {

                while (arv1 < arv2)
                {
                    int komata = arv1 / 2;
                    double komaga = (double)arv1 / 2;
                    if (komata == komaga)
                    {
                        Console.WriteLine(arv1);
                        arv1++;
                    }
                    else
                    {
                        arv1++;
                    }
                }
            }
            if (arv1 > arv2)
            {

                while (arv2 < arv1)
                {
                    int komata = arv2 / 2;
                    double komaga = (double)arv2 / 2;
                    if (komata == komaga)
                    {
                        Console.WriteLine(arv2);
                        arv2++;
                    }
                    else
                    {
                        arv2++;
                    }
                }

            }

            Console.ReadKey();






        }

    }
}
