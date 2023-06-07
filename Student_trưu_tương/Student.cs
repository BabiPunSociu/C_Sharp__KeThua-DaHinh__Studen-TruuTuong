using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_trưu_tương
{
     abstract class Student
    {
        protected int id;
        protected string name;
        protected int year; // year of birth
        public Student(int id, string name, int year)
        {
            this.id = id;
            this.name = name;
            this.year = year;
        }

        protected void display()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Thông tin sinh viên:");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
        }

        public abstract  Double Average();   // Tính điểm trung bình
    }
}
