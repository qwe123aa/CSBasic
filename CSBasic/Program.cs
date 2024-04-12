using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#에서도 헬로월드를?
            Console.WriteLine("Hello World?!");

            //오버플로우 연습
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a+b);

            //오버플로우 연습2
            Console.WriteLine((long)a+b);
            Console.WriteLine(a+(long)b);
            Console.WriteLine((long)a + (long)b);

        }
    }
}
