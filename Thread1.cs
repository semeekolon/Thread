using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)

        {
            Thread oThread1 = new Thread(Function1);
            Thread oThread2 = new Thread(Function2);
            Thread oThread3 = new Thread(Function3);

            oThread1.Start();
            oThread2.Start();
            oThread3.Start();

            Console.ReadKey();

        }

       


        static void Function1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Function 1 executed {0}", i.ToString() );
              
            }
        }

        static void Function2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Function 2 executed {0}", i.ToString());
              
            }
        }

        static void Function3()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Function 3 executed {0}", i.ToString());

            }
        }
    }
}
