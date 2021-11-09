using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            Sinlett sin = Sinlett.VizovSingl();
            Console.WriteLine($"Счётчик при вызове инстанса {Sinlett.Zahod}");

            Sinlett sin_2 = Sinlett.VizovSingl();
            Console.WriteLine($"Счётчик при вызове инстанса {Sinlett.Zahod}");

            Console.ReadLine();

        }
    }

    
    public class Sinlett
    {
        public static int Zahod { get; set; }
        private static object Zahod0 = null;
        public static Sinlett sn;
        private Sinlett()
        {
            ++Zahod;
        }

        public static Sinlett VizovSingl()
        {
            if (sn == Zahod0)
            {
                sn = new Sinlett();
            }

            return sn;
        }
    }
}
