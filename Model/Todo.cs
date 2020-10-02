using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Model
{
    /*a.Requiredprivatefields are todoId(int and readonly), description(String), done(bool)and assignee(Person).
      b.Make a constructor that take in todoId(int) and a description(String).
      c.Unit test Todoclass.
      d.Commit changes.*/

    public class Todo
    {
        //required fields
        private int todoId = 0;
        public int TodoId 
        { 
            get 
            { 
                return todoId; 
            }
        }

        private string description = "";
        public string Description 
        { 
            get 
            { 
                return description; 
            } 
            set 
            {
                this.description = value;
            } 
        }

        private bool done;
        public bool Done 
        { 
            get 
            { 
                return done; 
            } 
            set 
            {
                this.done = value;
            }
        }

        private Person asignee;
        public Person Assignee
        {
            get
            {
                return asignee;
            }
            set
            {
                this.asignee = value;
            }
        }





        //constructors
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;

        }

    }
}
