using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book firstBook = new Book("Gatsby", "F. Scott Fitzgerald", "9780743273565");
            Book secondBook = new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084");
            Book thirdBook = new Book("1984", "George Orwell", "9780451524935");
          
               
         
            Library library = new Library();



            library.AddBook(firstBook);
            library.AddBook(secondBook);
            library.AddBook(thirdBook);

            library.BorrowBook("Gatsby");
            library.BorrowBook("", "Harper Lee");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); //not found

            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter");



            //  library.PrintList();




        }
    }
}
