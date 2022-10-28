using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    internal class Program
    {

        class Student
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"Id: {Id} \tTen: {Name} \t Age: {Age}";
            }
        }

        class Lecturer
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public override string ToString()
            {
                return $"Id: {Id} \tTen: {Name} \t Salary: {Salary}";
            }
        }
        class PersonManager<T>
        {
            private List<T> _listPerson = new List<T>();
            public void Add(T person)
            {
                _listPerson.Add(person);
            }

            public void Display()
            {
                foreach (T obj in _listPerson)
                {
                    Console.WriteLine($"{obj}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "20521097-Doan Quoc Bao";
            Console.OutputEncoding = Encoding.Unicode;

            PersonManager<Lecturer> lecturer = new PersonManager<Lecturer>();
            lecturer.Add(new Lecturer { Id = "1001", Name = "Ted", Salary = 200 });
            lecturer.Add(new Lecturer { Id = "1002", Name = "Robin", Salary = 500 });
            lecturer.Add(new Lecturer { Id = "1003", Name = "Batman", Salary = 1000 });

            PersonManager<Student> student = new PersonManager<Student>();
            student.Add(new Student { Id = "2001", Name = "King Kong", Age = 10 });
            student.Add(new Student { Id = "2002", Name = "T-Rex", Age = 15 });
            student.Add(new Student { Id = "2003", Name = "Shark", Age = 16 });

            Console.WriteLine("Thông tin Lecture:");
            lecturer.Display();
            Console.WriteLine("Thông tin Student:");
            student.Display();
            
            Console.ReadKey();
        }
    }
}
