using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using CsvHelper;
using System.Text;
using System.Linq;
namespace ConsoleApp1
{
    sealed class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirthday { get; set; }
        public Student(string name, string surname, string dateOfBirthday)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = dateOfBirthday;
        }

        public void ChangeName(Student student, string name)
        {
            if (student != null && student.Name != name)
            {
                student.Name = name;
            }
        }

        public void ChangeSurname(Student student, string surname)
        {
            if (student != null && student.Name != surname)
            {
                student.Surname = surname;
            }
        }

        public void ChangeDateOfBirthday(Student student, string dateOfBirthday)
        {
            if (student != null && student.Name != dateOfBirthday)
            {
                student.DateOfBirthday = dateOfBirthday;
            }
        }
        public int CompareTo(Student that)
        {
            return String.Compare(Name, that.Name, System.StringComparison.Ordinal);
        }
    }



    class StudentGroup
    {
        List<Student> students = new List<Student>();

        public void AddStudent(string name, string surname, string dateOfBirthday)
        {
            Student student = new Student(name, surname, dateOfBirthday);
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public string GetStudent(int id)
        {
            return students[id].Name + " " + students[id].Surname + " " + students[id].DateOfBirthday;
        }

        public void ShowAllStudent()
        {
            Console.WriteLine("Все студенты: ");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + "\t" + student.Surname + "\t" + student.DateOfBirthday);

            }
        }
        public int GetAmount()
        {
            return students.Count;
        }
        public int Sort_Ar()
        {
             students.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
            return 0;
        }
        
    
        public void Loadr(int id)
        {
            string writePath = @"Text.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {

                    var result = from s in students select s;
                    // sw.WriteLine( );
                    for (int i = 0; i < 12; i++) { 
                    sw.WriteLine(students[i].Name.ToString() + " " + students[i].Surname.ToString()); }
                    Console.WriteLine("Запись выполнена");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
         

    }


    class Program
    {
        static void Main(string[] args)
        {
            var studentGroup = new StudentGroup();
            studentGroup.AddStudent("Ivan", "Ivanov", "01.07.2000");
            studentGroup.AddStudent("Petya", "Petrov", "28.02.2001");
            studentGroup.AddStudent("Sidor", "Sidorov", "05.09.1999");
            studentGroup.AddStudent("Artem", "Radko", "07.10.1998");
            studentGroup.AddStudent("Kirill", "Merkulo", "15.12.2000");
            studentGroup.AddStudent("Mark", "Kolosov", "30.01.2001");
            studentGroup.AddStudent("Valya", "Kunov", "11.04.1999");
            studentGroup.AddStudent("Soren", "Porev", "27.05.1998");
            studentGroup.AddStudent("Kenn", "Liaber", "23.06.1999");
            studentGroup.AddStudent("Valya", "Kunov", "12.04.1999");
            studentGroup.AddStudent("Anna", "Kim", "29.05.1998");
            studentGroup.AddStudent("Sonmi", "Lim", "21.06.1999");
        

            studentGroup.ShowAllStudent();
            Console.WriteLine("Общее количество студентов в группе " + studentGroup.GetAmount());

            studentGroup.Sort_Ar();
            Console.WriteLine("Сортировка имени по алфавиту ");
            studentGroup.ShowAllStudent();

            Console.WriteLine("1. Нажмите для записи в txt файл\n2. Нажмите для выхода\n");
            string a = Console.ReadLine();
            if (a == "2")
            {
                Console.WriteLine("\nОжидайте выхода");
                Environment.Exit(0);
            }
            if (a == "1")
            {
                for (int i = 0; i < 12; i++) { studentGroup.Loadr(i); }
            }
       
                Console.WriteLine("\nПроисходит выход");
                Console.ReadKey();
        }
    }
}
