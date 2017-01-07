using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaCrypt
{
    class Contact
    {
        private int entrance;
        private int exit;
        public Contact(int entrance, int exit)
        {
            this.entrance = entrance;
            this.exit = exit;
        }
        public void turn()
        {
            entrance++;
            exit++;
            if(entrance > 94)
            {
                entrance = 0;
            }
            if(exit > 94)
            {
                exit = 0;
            }

        }
        public int getEntrance()
        {
            return entrance;
        }
        public int getExit()
        {
            return exit;
        }
    }
}
