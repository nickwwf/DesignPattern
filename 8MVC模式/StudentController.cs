﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8MVC模式
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            model.Name = name;
        }

        public string GetStudentName()
        {
            return model.Name;
        }

        public void SetStudentRollNo(string rollNo)
        {
            model.RollNo = rollNo;
        }

        public string GetStudentRollNo()
        {
            return model.RollNo;
        }

        public void UpdateView()
        {
            view.PrintStudentDetails(model.Name, model.RollNo);
        }
    }
}
