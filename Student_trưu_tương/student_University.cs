/*      Lớp sinh viên đại học "student_University" Kế Thừa class sinh viên cao đẳng "student_College"
 *      Có thêm điểm thứ 4 và ghi đè lại phương thức điểm trung bình Avg()
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_trưu_tương
{
    class student_University : student_College
    {
        protected double core4;

        public student_University(int id, string name, int year, double core1,double core2, double core3, double core4) : base(id, name, year, core1, core2, core3)
        {
            this.core4 = core4;
        }

        public override double Average()
        {
            return (core1 + core2 + core3 + core4) / 4;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Core 4: " + core4);
        }
    }
}
