using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV03
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            if (book.Title is null)
                return "Book Not Exist";

                return book.Title;
        }
        public static string GetAuthors(Book book)
        {
            if (book.Authors is null)
                return "Not Found";
            return string.Join(", ", book.Authors);
        }
        public static string GetPrice(Book book)
        {
            return book.Price.ToString();
        }
    }
}
