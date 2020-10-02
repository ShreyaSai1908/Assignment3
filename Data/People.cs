using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using Assignment3.Model;


namespace Assignment3.Data
{
    public class People
    {
        //private static Person array declared here
        private static Person [] personArray= new Person[0];

        //private static Person List is declared to make the size of the personArray dynamic
        private static List<Person> personList = new List<Person>();

        //Add a method public int Size()that return the length of the array
        public int Size()
        {
            return personArray.Length; 
        }

        //Add a method public Person[] FindAll()that return the Person array
        public Person[] FindAll()
        {
            return personArray;           
        }

        //Add a method public Person FindById(int personId)
        //that return the person that has a matching personId as the passed in parameter
        public Person FindById(int personId)
        {
            Person[] allpersons= FindAll();
            Person actualPerson = allpersons[0];

            foreach (Person person in allpersons)
            {
                if (person.PersonId == personId)
                {
                    actualPerson = person;
                    break;
                }                
            }
            return actualPerson;
        }

        public void addPersonToPeopleArray(Person p)
        {
            personList.Add(p);
            personArray = personList.ToArray();
        }

        public void Clear()
        {
            personList.Clear();
            personArray = personList.ToArray();
        }

        public void removePersonFromPersonArray(Person removePerson)
        {
            Person[] allPersons = FindAll();
            List<Person> newPersonList = new List<Person>();

            foreach (Person person in allPersons)
            {
                if (person.PersonId != removePerson.PersonId)
                {
                    newPersonList.Add(person);
                }
            }

            personArray = newPersonList.ToArray();

        }


    }

             
    
}
