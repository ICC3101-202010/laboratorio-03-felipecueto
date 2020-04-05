using System;
namespace Lab3
{
    public class Person
    {
        protected string name;
        protected string lastname;
        protected int id;
        protected string birthDate;
        protected string nationality;

        public Person(string name,string lastname,int id, string birthDate, string nationality)
        {
            this.name = name;
            this.lastname = lastname;
            this.id = id;
            this.birthDate = birthDate;
            this.nationality = nationality;
       
        }

        

        public string Name
        {
            get { return name; }  
        }

        public string Lastname
        {
            get { return lastname; }
        }

        public int Id
        {
            get { return id; }
        }

        public string BirthDate
        {
            get { return birthDate; }
        }

        public string Nationality
        {
            get { return nationality; }
        }
    }
   
}

