using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine($"The book {title}, was written by {author} and it has {pages} pages.");
        }
    }
}
