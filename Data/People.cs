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
            int personArrayNewSize = Size() + 1;
            Array.Resize<Person>(ref personArray, personArrayNewSize);
            personArray[personArrayNewSize-1] = p;
        }

        public Person addNewPerson(String fname, String lname)
        {
            int personId;
            personId= PersonSequencer.nextPersonId();
            Person p = new Person(personId,fname,lname);
            addPersonToPeopleArray(p);
            return p;
        }

        public void Clear()
        {
            int personArrayNewSize = 0;
            Array.Resize<Person>(ref personArray, personArrayNewSize);            
        }

        public void removePersonFromPersonArray(Person removePerson)
        {
            Person[] allPersons = FindAll();
            int personArraySize = Size();
            int removePersonIndex = 0;

            for (int i = 0; i < personArraySize; i++)
            {
                if (allPersons[i].PersonId == removePerson.PersonId)
                {
                    removePersonIndex = i;
                    break;
                }
            }

            for (int i = removePersonIndex; i < personArraySize-1; i++)
            {
                allPersons[i] = allPersons[i + 1];
            }

            Array.Resize<Person>(ref allPersons, personArraySize-1);
            personArray = allPersons;

        }


    }

             
    
}
