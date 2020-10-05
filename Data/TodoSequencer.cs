using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Assignment3.Data
{
   public class TodoSequencer
    {
        public static int todoId;
        

        public static int nextToDoId()
        {
            todoId++;
            return todoId;
        }

        public static void reset()
        {
            todoId = 0;
        }
    }
}
