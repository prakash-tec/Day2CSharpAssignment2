using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class MarkMainClass
    {
        public static void Main()
        {
            MarksStudent m1 = new MarksStudent
            {
                RollNo = 1234,
                Name = "Akash",
                ClassName = 11,
                Semester = 4,
                Branch = "CSE",

            };
            m1.Marks[0] = 50.0;
            m1.Marks[1] = 60.0;
            m1.Marks[2] = 70.0;
            m1.Marks[3] = 80.0;
            m1.Marks[4] = 90.0;

            m1.Average = m1.CalculateAverage();
            m1.Result = m1.PassFail();
            m1.Display();
            Console.ReadLine();
        }
    }
}

