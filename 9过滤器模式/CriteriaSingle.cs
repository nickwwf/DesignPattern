using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9过滤器模式
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.GetMaritalStatus.Equals("SINGLE", StringComparison.OrdinalIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
