using System;
using System.Collections.Generic;
using System.Linq;

namespace _9过滤器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.MeetCriteria(persons));
        }

        public static void printPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.GetName
                   + ", Gender : " + person.GetGender
                   + ", Marital Status : " + person.GetMaritalStatus
                   + " ]");
            }
        }
    }
}
