using System;
using System.Text;
using System.Threading.Tasks;

namespace FCC_Bootcamp
{
    // This is a child of the Book class
    class SpecFicBook : Book
    {
        // This should be a constructor
        public SpecFicBook(string aTitle, string aAuthor, int aPages)
        {   
            title = aTitle;
            author = aAuthor;
            pageCount = aPages;
        }
    }
}