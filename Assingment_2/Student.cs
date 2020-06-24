using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class Student
    {
        public int RollNo;
        public string StudName;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;
        public double marks;
        public double percentage;
        public void Details()
        {
            Console.WriteLine("RollNo: " + RollNo);
            Console.WriteLine(" StudName: " + StudName);
            Console.WriteLine("MarksInEng: " + MarksInEng);
            Console.WriteLine("MarksInMaths: " + MarksInMaths);
            Console.WriteLine("MarksInScience: " + MarksInScience);
        }
        public void markAdd()
        {
            marks = MarksInScience + MarksInEng + MarksInMaths;
            Console.WriteLine("Marks: " + marks);
        }
        public void perc()
        {
            percentage = marks / 3;
            Console.WriteLine("Percentage: " + percentage);
        }
    }
    class StudentTest
    {
        public static void Main()
        {

            Student s1 = new Student();
            s1.RollNo = 1;
            s1.StudName = "prakash";
            s1.MarksInMaths = 97.00;
            s1.MarksInScience = 98.00;
            s1.MarksInEng = 69.00;
            s1.Details();
            s1.markAdd();
            s1.perc();

            Student s2 = new Student();
            s2.RollNo = 2;
            s2.StudName = "lopa";
            s2.MarksInMaths = 37.00;
            s2.MarksInScience = 99.00;
            s2.MarksInEng = 79.00;
            s2.Details();
            s2.markAdd();
            s2.perc();
            Console.ReadKey();
        }
    }
}

