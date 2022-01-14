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
            list.Add(new Student("Ivan", "Ivanov", 222, "ab"));
            list.Add(new Student("Bulka", "Bulov", 221, "abd"));
            list.Add(new Student("Iskander", "Iskov", 202, "a"));
            list.Add(new Student("Andrey", "Ibanov", 321, "b"));
            return list;
        }
    }
    public class Car
    {
        public string name;
        public string fuel;
        public int date;
        public string mileage;

        public Car(string name, string fuel, int date, string mileage)
        {
            this.name = name;
            this.fuel = fuel;
            this.date = date;
            this.mileage = mileage;
        }
        public static List<Car> GetCar()
        {
            List<Car> list = new List<Car>();
            list.Add(new Car("Audi", "disel", 2000, "2000km"));
            list.Add(new Car("BMW", "Benzin", 2005, "3200km"));
            list.Add(new Car("Ford", "disel", 2008, "1600km"));
            list.Add(new Car("Honda", "disel", 2006, "1743km"));
            return list;
        }
    }
    public class Game
    {
        public string name;
        public int date;
        public string izdatel;
        public string janr;

        public Game(string name, int date, string izdatel, string janr)
        {
            this.name = name;
            this.date = date;
            this.izdatel = izdatel;
            this.janr = janr;
        }
        public static List<Game> GetGame()
        {
            List<Game> list = new List<Game>();
            list.Add(new Game("Gtu 3", 2002, "Rocksutr", "Shooter in 3rd person"));
            list.Add(new Game("Fra Crye 3", 2005, "Ebisoft", "Open-world"));
            list.Add(new Game("Marui", 1999, "Nunet", "Platform"));
            list.Add(new Game("Left 4 inside 2 ", 2001, "Vulve", "Shooter 1st person"));
            return list;
        }
    }
}
