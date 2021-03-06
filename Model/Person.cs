﻿using Assignment3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Model
{
    public class Person
    {
        //field name: personId
        //field modifier : private
        private readonly int personId;

        //field property: PersonId
        //property modifier: public
        public int PersonId { get { return personId; } }

        //field name: firstName
        //field modifier : private
        private string firstName = "";

        //field property: FirstName
        //Requirement: to prevent names from saving NULL & Empty
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName is null, empty, or consists only of white-space");
                }
                else
                {
                    firstName = value;
                }
            }

        }

        //field name: lastName
        //field modifier : private
        private string lastName = "";

        //field property: LastName
        //Requirement: to prevent names from saving NULL & Empty
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName is null, empty, or consists only of white-space");
                }
                else
                {
                    lastName = value;
                }
            }

        }

        //constructor
        public Person(string firstName, string lastName)
        {
            //++personId;

            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //overloaded constructor
        public Person(int pid, string firstName, string lastName)
        {
            personId=pid;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //method to return person information as a String                  
        /*public string PersonInformation()
        {
            return $"Person Id:{personId} \nFirstName: {firstName}\nLastName: {lastName}";

        }*/

    }
}
