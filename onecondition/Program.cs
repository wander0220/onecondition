﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력 : ");
            int x = int.Parse(Console.ReadLine());


            if (x > 10)
            {
                if (x < 20)
                {
                    Console.WriteLine("조건에 맞습니다.");
                }
            }

        }
    }
}
