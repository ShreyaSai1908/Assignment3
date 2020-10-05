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
            int toDoArrayNewSize = Size() + 1;
            Array.Resize<Todo>(ref todoArray, toDoArrayNewSize);
            todoArray[toDoArrayNewSize - 1] = p;
        }

        public Todo addNewTodo(String desc)
        {
            Todo td = new Todo(desc);
            addToDoToTodoItemsArray(td);
            return td;
        }

        public void Clear()
        {
            int toDoArrayNewSize = 0;
            Array.Resize<Todo>(ref todoArray, toDoArrayNewSize);
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] allToDo = FindAll();
            Todo[] actualToDo = new Todo[0];
            int doneTodoCount = 0;

            for (int i = 0; i < allToDo.Length; i++)
            {
                if (allToDo[i].Done == doneStatus)
                {
                    doneTodoCount++;
                    Array.Resize<Todo>(ref actualToDo, doneTodoCount);
                    actualToDo[doneTodoCount-1] = allToDo[i];
                }
            }
            return actualToDo;
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] allToDo = FindAll();
            Todo[] actualToDo = new Todo[0];
            int doneTodoCount = 0;
            
            for (int i = 0; i < allToDo.Length; i++)
            {
                Person p = allToDo[i].Assignee;
                if (p.PersonId == personId)
                {
                    doneTodoCount++;
                    Array.Resize<Todo>(ref actualToDo, doneTodoCount);
                    actualToDo[doneTodoCount - 1] = allToDo[i];                    
                }
            }
            return actualToDo;

        }

        public Todo[] FindByAssignee(Person person)
        {
            Todo[] allToDo = FindAll();
            Todo[] actualToDo = new Todo[0];
            int doneTodoCount = 0;

            for (int i = 0; i < allToDo.Length; i++)
            {
                Person p = allToDo[i].Assignee;
                if (p.PersonId == person.PersonId)
                {
                    doneTodoCount++;
                    Array.Resize<Todo>(ref actualToDo, doneTodoCount);
                    actualToDo[doneTodoCount - 1] = allToDo[i];
                }
            }
            return actualToDo;           
        }

        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] allToDo = FindAll();
            Todo[] actualToDo = new Todo[0];
            int doneTodoCount = 0;

            for (int i = 0; i < allToDo.Length; i++)
            {
                Person p = allToDo[i].Assignee;
                if (p==null)
                {
                    doneTodoCount++;
                    Array.Resize<Todo>(ref actualToDo, doneTodoCount);
                    actualToDo[doneTodoCount - 1] = allToDo[i];
                }
            }
            return actualToDo;
        }

        public void removeTodoFromToDoArray(Todo removeTodo)
        {
            Todo[] allToDo = FindAll();
            int todoArraySize = Size();
            int removeTodoIndex = 0;

            for (int i = 0; i < todoArraySize; i++)
            {
                if (allToDo[i].TodoId == removeTodo.TodoId)
                {
                    removeTodoIndex = i;
                    break;
                }
            }

            for (int i = removeTodoIndex; i < todoArraySize - 1; i++)
            {
                allToDo[i] = allToDo[i + 1];
            }

            Array.Resize<Todo>(ref allToDo, todoArraySize - 1);
            todoArray = allToDo;

        }

     }
}
