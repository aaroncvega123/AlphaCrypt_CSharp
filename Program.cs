using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = Console.ReadLine();
            WheelSet newSet = new WheelSet("RIP Alan Turing");
            message = newSet.encryptString(message);
            Console.WriteLine(message);
            Console.ReadLine();

            /*List<int> intList = new List<int>();
            for (int i = 32; i < 127; i++)
            {
                intList.Add(i);
            }
            Console.WriteLine(intList.Count);
            Console.ReadLine();*/
        }
    }
}
