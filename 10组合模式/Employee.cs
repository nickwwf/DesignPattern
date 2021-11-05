using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10组合模式
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return subordinates;
        }

        public override string ToString()
        {
            return ("Employee :[ Name : " + name
      + ", dept : " + dept + ", salary :"
      + salary + " ]");
        }
    }
}
