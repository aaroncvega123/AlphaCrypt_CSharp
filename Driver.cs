using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Driver
    {
        static void Main(string[] args)
        {
            String message = Console.ReadLine();
            WheelSet newSet = new WheelSet("RIP Alan Turing");
            message = newSet.encryptString(message);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
