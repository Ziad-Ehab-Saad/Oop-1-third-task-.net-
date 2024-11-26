using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Book
    {
        string title, author ,isbn;
       
        bool availablility;

        public Book(string title = "noTitle", string author = " noAuthor", string isbn = "0000", bool availability = true)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availablility = availability;

        }

        public string GetAuthor()
        {
            return author;

        }
        public string GetTitle()
        {
            return title;

        }
        public string GetIsbn()
        {
            return isbn;

        }
        public bool GetAvailability()
        {
            return availablility;

        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
                
        }
        public void SetAvailablility(bool availablility)
        {
            this.availablility = availablility;
        }






    }
}
