/*    Lớp sinh viên cao đẳng Kế Thừa lớp student
    Có thêm 3 điểm và ghi đè phương thức Avg()
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_trưu_tương
{
    class student_College : Student
    {
        protected double core1, core2, core3;

        public student_College(int id,string name, int year, double core1, double core2, double core3) : base(id, name, year)
        {
            this.core1 = core1;
            this.core2 = core2;
            this.core3 = core3;
        }

        public override Double Average()
        {
            return (core1 + core2 + core3) / 3;
        }

        public new void display()
        {
            base.display();
            Console.WriteLine("Core 1: " + core1);
            Console.WriteLine("Core 2: " + core2);
            Console.WriteLine("Core 3: " + core3);

        }
    }
}
