using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    class Program
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
            Console.ReadKey();
            bookStore.Display();

        }
    }
}
