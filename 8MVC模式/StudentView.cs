using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8MVC模式
{
    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: \r\n");
            Console.WriteLine("Name: " + studentName + "\r\n");
            Console.WriteLine("Roll No: " + studentRollNo);
        }
    }
}
