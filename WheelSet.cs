using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class WheelSet
    {
        private List<Rotor> wheelSet = new List<Rotor>();
        private List<int> turnsPerWheel = new List<int>();
        //private char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        //need to adjust number 26 for all configurations
        private List<int> ASCIIcodes = new List<int>();
        public WheelSet(String seedString)
        {
            for(int i = 32; i < 127; i++)
            {
                ASCIIcodes.Add(i);
            }
            int incrementer = 10;
            for(int i = 0; i < seedString.Length; i++)
            {
                turnsPerWheel.Add(0);
            }
            for (int i = 0; i < seedString.Length - 1; i++)
            {
                int input = Convert.ToInt32((int)seedString[i] + incrementer);
                wheelSet.Add(new Wheel(input));
                incrementer++;
            }
            wheelSet.Add(new Reflector(Convert.ToInt32(seedString[seedString.Length - 1])));
        }
        public String encryptString(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += encryptChar(input[i]);
            }
            return output;
        }
        public char encryptChar(char input)
        {
            int ascii = input;
            int index = 0;
            if (ascii >= 32 && ascii < 127)
            {
                for (int i = 0; i < 95; i++)
                {
                    if(ascii == ASCIIcodes[i])
                    {
                        index = i;
                        break;
                    }
                }
                fullRotate();
                index = descend(ascend(index));
                input = (char)ASCIIcodes[index];
            }
            else
            {
                fullRotate();
            }
            return input;
        }
        public int ascend(int input)
        {
            int output = input;
            for (int i = 0; i < wheelSet.Count; i++)
            {
                for(int k = 0; k < wheelSet[i].wheelPaths.Count; k++)
                {
                    if(output == wheelSet[i].wheelPaths[k].getEntrance())
                    {
                        output = wheelSet[i].wheelPaths[k].getExit();
                        break;
                    }
                }
            }
            return output;
        }
        public int descend(int input)
        {
            int output = input;
            for (int i = wheelSet.Count - 2; i >= 0; i--)
            {
                for (int k = 0; k < wheelSet[i].wheelPaths.Count; k++)
                {
                    if (output == wheelSet[i].wheelPaths[k].getExit())
                    {
                        output = wheelSet[i].wheelPaths[k].getEntrance();
                        break;
                    }
                }
            }
            return output;
        }
        public List<Rotor> getWheelSet()
        {
            return wheelSet;
        }
        public void fullRotate()
        {
            for(int i = 0; i < turnsPerWheel.Count; i++)
            {
                if(turnsPerWheel[i] < 94)
                {
                    rotateOne(i);
                    turnsPerWheel[i]++;
                    break;
                }
                else
                {
                    rotateOne(i);
                    turnsPerWheel[i] = 0;
                }
            }
        }
        //turns a single wheel by one click
        public void rotateOne(int index)
        {
            for(int i = 0; i < wheelSet[index].wheelPaths.Count; i++)
            {
                wheelSet[index].wheelPaths[i].turn();
            }
        }
        public void printWheelSet()
        {
            for(int i = 0; i < wheelSet.Count; i++)
            {
                wheelSet[i].printWheel();
            }
        }
    }
}
