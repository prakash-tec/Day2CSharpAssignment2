using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    public class BookStore
    {
        public long isbn;
        public string bookname;
        public string booktitle;
        public string bookauthor;
        public int quantityofbooks;
        public double bookprice;
        public double n = 0;
        public double totalAmount = 1;
        public void Display()
        {
            Console.WriteLine("Isbn No: " + isbn);
            Console.WriteLine(" BookName: " + bookname);
            Console.WriteLine("BookTitle: " + booktitle);
            Console.WriteLine("BookAuther: " + bookauthor);
            Console.WriteLine("No of Books avialble: " + quantityofbooks);
            Console.WriteLine("Price of book: " + bookprice);
        }
        public void quantity()
        {
            Console.WriteLine("Enter how many book");
            n = int.Parse(Console.ReadLine());
        }
        public void calculateAmount()
        {
            totalAmount = bookprice * n;
            Console.WriteLine("Total amount to paid " + totalAmount);

        }


    }
    class Prg_test
    {
        static void Main(string[] args)
        {
            BookStore bookStore = new BookStore();
            bookStore.isbn = 125243536;
            bookStore.bookname = "java";
            bookStore.bookauthor = "sonki";
            bookStore.booktitle = "padhi production";
            bookStore.quantityofbooks = 5;
            bookStore.bookprice = 5000;
            bookStore.quantity();
            bookStore.calculateAmount();
            bookStore.Display();
            Console.ReadKey();
           

        }
    }
}