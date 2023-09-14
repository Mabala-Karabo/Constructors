using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Pages;

        //comstructor with methods
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
        }
    }
}
