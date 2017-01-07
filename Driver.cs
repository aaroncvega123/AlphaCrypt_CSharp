using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to encrypt.");
            String message = Console.ReadLine();
            
            //Encryption
            WheelSet newSet = new WheelSet("RIP Alan Turing");
            message = newSet.encryptString(message);
            Console.WriteLine("Encrypted message: " + message);
            
            //Decryption
            newSet = new WheelSet("RIP Alan Turing");
            message = newSet.encryptString(message);
            Console.WriteLine("Decrypted message: " + message);
            
            Console.ReadLine();
        }
    }
}
