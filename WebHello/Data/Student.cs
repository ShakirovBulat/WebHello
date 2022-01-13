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
        public static List<Student> GetStudents()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Ivan", "Ivanov", 222, "abd"));
            return list;
        }
    }
}
