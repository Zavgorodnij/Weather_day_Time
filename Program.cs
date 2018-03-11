using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weather_day
{
    
    class Program
    {
        static int time = 0;
        static bool triger = true;
        static void Main(string[] args)
        {
            do
            {
                time = time + 30;
                Thread.Sleep(1000);
                Console.WriteLine("Положение солнца изменилось с течением времени");
                if (time==90)
                {
                    Console.WriteLine("Утро");
                }
                if (time==150)
                {
                    Console.WriteLine("Полдень");
                }
                if (time==270)
                {
                    Console.WriteLine("Вечер");
                }
                if (time==300)
                {
                    Console.WriteLine("Полночь");
                    time = 0;
                }
            } while (triger == true);
        }
    }
}
