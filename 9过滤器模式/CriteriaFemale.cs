using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9过滤器模式
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.GetGender.Equals("FEMALE", StringComparison.OrdinalIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
