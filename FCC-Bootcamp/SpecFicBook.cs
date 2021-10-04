using System;
using System.Text;
using System.Threading.Tasks;

namespace FCC_Bootcamp
{
    // This is a child of the Book class
    class SpecFicBook : Book
    {
        // This should be a constructor for a child class
        public SpecFicBook(string aTitle, string aAuthor, int aPages) : base( aTitle,  aAuthor,  aPages)
        {
            base.Title = title;
            base.author = aAuthor;
            base.pageCount = aPages;
        }
    }
}