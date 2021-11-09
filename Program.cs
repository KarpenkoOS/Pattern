using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinOchka
{
    class Program
    {
        static void Main(string[] args)
        {
            ОдинОчка очко = ОдинОчка.ДайМнеОчко();
            Console.WriteLine($"Каунтер при первом вызове инстанса {ОдинОчка.Пробитий}");

            ОдинОчка очкоВторое = ОдинОчка.ДайМнеОчко();
            Console.WriteLine($"Каунтер при втором вызове инстанса {ОдинОчка.Пробитий}");

            Console.ReadLine();

        }
    }

    // ОдинОчка
    public class ОдинОчка
    {
        public static int Пробитий { get; set; }
        private static object Пробито = null;
        public static ОдинОчка Очко;
        private ОдинОчка()
        {
            ++Пробитий;
        }

        public static ОдинОчка ДайМнеОчко()
        {
            if (Очко == Пробито)
            {
                Очко = new ОдинОчка();
            }

            return Очко;
        }
    }
}
