﻿using DIPatternDemo1.Models;

namespace DIPatternDemo1.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudent();
        Student GetStudentByRollNo(int id);
        int AddStudent(Student std);
        int UpdateStudent(Student std);
        int DeleteStudent(int id);
    }
}
