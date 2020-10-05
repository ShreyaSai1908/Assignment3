using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment3.Data
{
    public class PersonSequencer
    {
        //field
        private static int personId;

        
        /*
        //field
        private static int personId;

        //property
        public static int PersonID
        {
            get 
            {
                return personId;
            }
            set
            {
                personId = value;
            }
        }*/

        public static int nextPersonId()
        {
            personId++;
            return personId;
        }

        public static void reset()
        {
            personId = 0;
        }


    }
}
