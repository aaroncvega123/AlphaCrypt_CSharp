using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Wheel : Rotor
    {
        public Wheel(int seed) : base()
        {
            List<int> exits = generateExits(seed);
            for(int i = 0; i < exits.Count; i++)
            {
                wheelPaths.Add(new Contact(i, exits[i]));
            }
        }
    }
}
