/*using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Wheel
    {
        private List<Contact> wheelPaths = new List<Contact>();
        private List<int> toBeUsed = new List<int>();
        public Wheel(int seed)
        {

            for (int i = 0; i < 26; i++)
            {
                toBeUsed.Add(i);
            }
            List<int> exits = generateExits(seed);
            for (int i = 0; i < exits.Count; i++)
            {
                wheelPaths.Add(new Contact(i, exits[i]));
            }
        }
        public List<int> generateExits(int seed)
        {
            int place = seed;
            List<int> exits = new List<int>();
            while (toBeUsed.Count > 0)
            {
                if (place < toBeUsed.Count)
                {
                    exits.Add(toBeUsed[place]);
                    toBeUsed.RemoveAt(place);
                    place = place + seed;
                }
                else if (place >= toBeUsed.Count)
                {
                    place = place - toBeUsed.Count;
                }
            }
            return exits;
        }
        public void printWheel()
        {
            for (int i = 0; i < wheelPaths.Count; i++)
            {
                Console.Write(" " + wheelPaths[i].getEntrance());
            }
            Console.WriteLine();
            for (int i = 0; i < wheelPaths.Count; i++)
            {
                Console.Write(" " + wheelPaths[i].getExit());
            }
            Console.WriteLine();

        }

        public List<int> getToBeUsed()
        {
            return toBeUsed;
        }
    }
}*/
