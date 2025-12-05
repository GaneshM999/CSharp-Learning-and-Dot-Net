using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class whythrding
    {
            public static void t1() // this is single thread models.
            {
                long count = 0;
                for (int i = 0; i < 1000000000; i++)
                {
                    count++;
                    Console.WriteLine("t1:" + count);
                }

            }
            public static void t2()
            {
                long count = 0;
                for (int i = 0; i < 1000000000; i++)
                {
                    count++;
                    Console.WriteLine("t2:" + count);
                }

            }
            public static void Main()
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                t1();
                t2();
                s.Stop();
                Console.WriteLine("time taken:" + s.ElapsedMilliseconds);
            }
        

    }

}


