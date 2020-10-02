using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Assignment3.Data
{
   public class TodoSequencer
    {
        public static int TodoId { get; set; }
        

        public static int nextToDoId()
        {
            TodoId++;
            return TodoId;
        }

        public static void reset()
        {
            TodoId = 0;
        }
    }
}
