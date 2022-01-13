using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHello.Data
{
    public class Student
    {
        public string name;
        public string surname;
        public int group;
        public string faculty;

        public Student(string name, string surname, int group, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.faculty = faculty;
        }
        //public List<Student> GetStudents()
        //{
           // new Student() = { name = "tom", surname="tomov", group=326, faculty="PP" };
        //}
    }
}
