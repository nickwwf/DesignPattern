using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9过滤器模式
{
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string GetName => name;
        public string GetGender => gender;
        public string GetMaritalStatus => maritalStatus;
    }
}
