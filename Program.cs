using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingclasseshomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing out the new class book created from reading homework
            Book book = new Book("Harry Potter");

            //change my ming lets do full title
            book.SetTitle("Hrry Potter ns rhw Half Blood Prince");

            //Now I for got what was the title again
            Console.WriteLine(Book.GetTitle());




        }
    }
}
