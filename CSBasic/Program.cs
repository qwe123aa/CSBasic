﻿using System;
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

            //자료형 최소, 최대 출력하기
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //sizeof 연산자 연습
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(bool));


        }
    }
}
