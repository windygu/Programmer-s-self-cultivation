﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {

            var fibonacciNumbers = new List<int> { 1,1 };
            
            //Console.WriteLine(previous2);
            //int now = 0;
            while (fibonacciNumbers.Count < 2)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                //Console.WriteLine(previous);
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];//count = index
                //now = ;
                fibonacciNumbers.Add(previous + previous2);
                
                
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
                Console.ReadKey();
        }
    }
}
