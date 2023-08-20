using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_sinif
{
    internal class Library 
    {
       public book[] books;
       public Library()
        {

            books = new book[0];
        } 

        public void AddBook(book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length-1]=book;
        }

    }
}
