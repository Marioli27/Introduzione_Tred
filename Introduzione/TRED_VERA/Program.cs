using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRED_VERA
{
    class Program
    {
        static void Main(string[] args)
        {
           //VisualizzaDisp();
           //Console.WriteLine();
           //VisualizzaPari();
           //Console.WriteLine();

            Task.Factory.StartNew(VisualizzaDisp);
            Task.Factory.StartNew(VisualizzaPari);

            Console.ReadLine();
        }

        public static void VisualizzaDisp()
        {
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }

       public static void VisualizzaPari()
       {
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
       }
    }
}
