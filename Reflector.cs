using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Reflector : Rotor
    {
        public Reflector(int seed) : base()
        {
            List<int> exits = generateExits(seed);
            List<int> entrances = generateEntrances(exits);
            for(int i = 0; i < exits.Count; i++)
            {
                wheelPaths.Add(new Contact(entrances[i], exits[i]));
            }
        }
        public List<int> generateEntrances(List<int> exits)
        {
            List<int> entrances = new List<int>();
            for(int i = 0; i < 94 - 1; i += 2)
            {
                entrances.Add(exits[i + 1]);
                entrances.Add(exits[i]);
            }
            return entrances;
        }
    }
}
