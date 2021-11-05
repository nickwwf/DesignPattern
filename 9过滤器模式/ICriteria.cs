using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9过滤器模式
{
    public interface ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons);
    }
}
