using System;

namespace _8MVC模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //从数据库获取学生记录
            Student model = retrieveStudentFromDatabase();

            //创建一个视图：把学生详细信息输出到控制台
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            //更新模型数据
            controller.SetStudentName("John");

            controller.UpdateView();
        }

        private static Student retrieveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }
}
