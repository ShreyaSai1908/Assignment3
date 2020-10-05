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

        //auto-properties
        public static int PersonId { get; set; }

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
            PersonId++;
            return PersonId;
        }

        public static void reset()
        {
            PersonId = 0;
        }


    }
}
