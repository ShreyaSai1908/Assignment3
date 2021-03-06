﻿using Assignment3.Data;
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
        private readonly int todoId = 0;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description is null, empty, or consists only of white-space");
                }

                else
                {
                    description = value;
                }

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
        public Todo(string description)
        {
            todoId = TodoSequencer.nextToDoId();
            this.Description = description;

        }

    }
}
