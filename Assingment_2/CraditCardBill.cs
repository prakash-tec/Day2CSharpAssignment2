using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class CraditCardBill
    {
        public static void Main()
        {
            int month = 1;
            Console.WriteLine("Enter the monthely payment: ");
            double pay = double.Parse(Console.ReadLine());
            double m = 1000;
            int counter = 0;
            double totalPayment = 0;

            while (m != 0)
            {
                counter++;
                m = m + (m * 0.015);
                if (!(m - pay < 0))
                {
                    m = m - pay;
                    totalPayment += pay;
                    Console.WriteLine("Month: " + counter + " Balance: " + m + " Total Payments: " + totalPayment);
                    Console.ReadLine();

                }

                else
                {
                    pay = m;
                    m = 0;
                    totalPayment += pay;
                    Console.WriteLine("Month: " + counter + " Balance: " + m + " Total Payments: " + totalPayment);
                }
            }

        

        }
        
    }
}
