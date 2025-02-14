namespace AssignmentADV03
{
    public delegate string UserDefinedDelegateForLibrary(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            List<Book> Books = new List<Book>()
            {
                   {new Book("123", "C# Programming", new string[] { "Mohamed", "Ahmed" }, DateTime.Now, 1000) },
                   { new Book("124", "C++ Programming", new string[] { "Fares", "Nada" }, DateTime.Now, 2500) },
                   { new Book("125", "C Programming", new string[] { "Heba", "Omar" }, DateTime.Now, 850) },
                   { new Book("126", "Java Programming", new string[] { "Nadeen", "Aya" }, DateTime.Now, 3300) },
                   { new Book("127", "Phyton Programming", new string[] { "Rokaia", "Ali" }, DateTime.Now, 5500) }
            };

            #region Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //UserDefinedDelegateForLibrary BookMethods = BookFunctions.GetTitle;
            ////LibraryEngine.ProcessBooks(Books, BookMethods);

            ////BookMethods += BookFunctions.GetAuthors;
            ////LibraryEngine.ProcessBooks(Books, BookMethods);

            //BookMethods += BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(Books, BookMethods); 
            #endregion

            #region Use the Proper build in delegate.

            //Func<Book,string> func = BookFunctions.GetTitle;
            ////LibraryEngine.ProcessBooks(Books, func);

            //func += BookFunctions.GetAuthors;
            ////LibraryEngine.ProcessBooks(Books, func);

            //LibraryEngine.ProcessBooks(Books, BookFunctions.GetPrice);
            #endregion

            #region Anonymous Method (GetISBN)

            //Func <Book,string> func = delegate (Book book)
            //{
            //    return book.ISBN!;

            //};
            //foreach (Book B in Books)
            //    Console.WriteLine(func.Invoke(B));
            #endregion

            #region Lambda Expression (Get PublicationDate)
            //foreach (Book B in Books)
            //    Console.WriteLine(GetPublicationDate(B));
                
            #endregion
            #endregion

            #region Part 03:We need to Implement the List methods from scratch with all overloads.

            List<int> list = [1, 2, 3, 4, 5];
            bool isExsist = ListMethods.Exist(Books, (b) => b.Price == 2000);
            Console.WriteLine(isExsist);
            bool flag = ListMethods.TrueForAll(Books, b => b.Title == "C#");
            #endregion
        }

        public static DateTime? GetPublicationDate(Book book) => book.PublicationDate;
    }

        
    
}