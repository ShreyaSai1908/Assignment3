using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Model;


namespace Assignment3.Data
{
    public class TodoItems
    {

        //private static Todo array declared here
        private static Todo[] todoArray = new Todo[0];

        //private static Person List is declared to make the size of the personArray dynamic
        private static List<Todo> todoList = new List<Todo>();

        //Add a method public int Size()that return the length of the array
        public int Size()
        {
            return todoArray.Length;
        }

        //Add a method public Person[] FindAll()that return the Person array
        public Todo[] FindAll()
        {
            return todoArray;
        }

        //Add a method public Person FindById(inttodoId)
        //that return the person that has a matching todoId as the passed in parameter
        public Todo FindById(int todoId)
        {
            Todo[] allToDo = FindAll();
            Todo actualToDo = null;

            foreach (Todo todo in allToDo)
            {
                if (todo.TodoId == todoId)
                {
                    actualToDo = todo;
                    break;
                }
            }
            return actualToDo;
        }

        public void addToDoToTodoItemsArray(Todo p)
        {
            todoList.Add(p);
            todoArray = todoList.ToArray();
        }

        public Todo addNewTodo(String desc)
        {
            //int tdid;
            //tdid = TodoSequencer.nextToDoId();
            Todo td = new Todo(desc);
            addToDoToTodoItemsArray(td);
            return td;
        }

        public void Clear()
        {
            todoList.Clear();
            todoArray = todoList.ToArray();
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] allToDo = FindAll();
            List <Todo> actualToDoList = new List<Todo>();

            foreach (Todo todo in allToDo)
            {
                if (todo.Done == doneStatus)
                {
                    actualToDoList.Add(todo);
                }
            }
            return actualToDoList.ToArray();

        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] allToDo = FindAll();
            List<Todo> actualToDoList = new List<Todo>();

            foreach (Todo todo in allToDo)
            {
                Person p = todo.Assignee;

                if (p.PersonId == personId)
                {
                    actualToDoList.Add(todo);
                }
            }
            return actualToDoList.ToArray();

        }

        public Todo[] FindByAssignee(Person person)
        {
            Todo[] allToDo = FindAll();
            List<Todo> actualToDoList = new List<Todo>();

            foreach (Todo todo in allToDo)
            {
                Person p = todo.Assignee;

                if (p.PersonId == person.PersonId)
                {
                    actualToDoList.Add(todo);
                }
            }
            return actualToDoList.ToArray();

        }

        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] allToDo = FindAll();
            List<Todo> actualToDoList = new List<Todo>();

            foreach (Todo todo in allToDo)
            {
                Person p = todo.Assignee;

                if (p==null)
                {
                    actualToDoList.Add(todo);
                }
            }
            return actualToDoList.ToArray();

        }

        public void removeTodoFromToDoArray(Todo removeTodo)
        {
            Todo[] allToDo = FindAll();
            List<Todo> newToDoList = new List<Todo>();

            foreach (Todo todo in allToDo)
            {
                if (todo.TodoId != removeTodo.TodoId)
                {
                    newToDoList.Add(todo);
                }
            }

            todoArray = newToDoList.ToArray();

         }



     }
}
