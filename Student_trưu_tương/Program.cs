using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_trưu_tương
{
    class Program
    {
        public static void Main()
        {
            // Tạo 1 sinh viên cao đẳng
            student_College sv1 = new student_College(1, "Vu Thu Hien", 2001, 8.5, 7.9, 9.3);
            sv1.display();
            Console.WriteLine("Điem trung bình: " + sv1.Average());


            // Tạo 1 sinh viên đại học
            student_University sv2 = new student_University(2, "Vu Thu Hien", 2001, 8.5, 7.9, 9.3, 10.0);
            sv2.display();
            Console.WriteLine("Điem trung bình: " + sv2.Average());
        }
    }
}