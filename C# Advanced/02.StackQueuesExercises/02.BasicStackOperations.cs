﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var toPush = int.Parse(input[0]);
            var toPop = int.Parse(input[1]);
            var magicNumber = int.Parse(input[2]);
            input = Console.ReadLine().Trim().Split();
            if (toPush == 0 || input.Length == 0 )
            {
                Console.WriteLine(0);
                return;
            }

            var stack = new Stack<int>();

            for (int i = 0; i < toPush; i++)
            {
                stack.Push(int.Parse(input[i]));
            }

            for (int y = 0; y < toPop; y++)
            {
                stack.Pop();
            }

            var list = new List<int>(stack);

            if (list.Contains(magicNumber))
            {
                Console.WriteLine("true");
            }
            else if(list.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(list.OrderBy(x=>x).First());
            }

        }
    }
}
