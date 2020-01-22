using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = Task.Factory.StartNew(() => Function1());
            var t2 = Task.Factory.StartNew(() => Function2());
            var t3 = Task.Factory.StartNew(() => Function3());

            var TaskList = new List<Task> { t1, t2, t3};
            Task.WaitAll(TaskList.ToArray());

            PrintMsg();
        }


        static void PrintMsg()
        {
                Console.WriteLine("Ek number Khatarnak Thread!");

        }

        static void Function1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Function 1 executed {0}", i.ToString());

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
