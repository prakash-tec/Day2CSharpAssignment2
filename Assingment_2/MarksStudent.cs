using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class MarksStudent
    {
        private int rollNo;
        private string name;
        private int className;
        private int semester;
        private string branch;
        private double average;
        private double[] marks = new double[5];
        private string result;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
        public int ClassName { get => className; set => className = value; }
        public int Semester { get => semester; set => semester = value; }
        public string Branch { get => branch; set => branch = value; }
        public double[] Marks { get => marks; set => marks = value; }
        public double Average { get => average; set => average = value; }
        public string Result { get => result; set => result = value; }

        public double CalculateAverage()
        {
            double sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            Average = sum / 5;
            return Average;
        }
        public string PassFail()
        {
            int flag = 1;

            foreach (int mark in marks)
            {
                if (mark < 35 || average < 50)
                {
                    result = "You Did Not Pass";

                    flag = 0;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag == 1)
            {

                result = "You Passed";
            }
            return result;
        }
        public void Display()
        {
            Console.WriteLine("Roll No : " + rollNo + "\nName : " + name + "\nClass : " + className + "\nSemester : " + semester + "\nBranch : " + branch + "\nAverage Marks : " + average + "\n\t" + result);

        }
    }
}

