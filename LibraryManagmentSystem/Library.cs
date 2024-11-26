using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Library
    {
        List<Book> books;
        public Library()
        {
            books = new List<Book>();
            
        }
       
        public void AddBook(Book oneBook)
        {
            if (oneBook != null)
            {
                books.Add(oneBook);

            }


        }

        public void PrintList()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"title = {books[i].GetTitle()}");
                Console.WriteLine($"Author = {books[i].GetAuthor()}");
                Console.WriteLine($"Isbn =  {books[i].GetIsbn()}");
                Console.WriteLine($"Availability = {books[i].GetAvailability()}");
                Console.WriteLine("============================");
            }

        }

        public void BorrowBook(string title,string author="")
        {
            bool flag = false;
            int data = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (title == books[i].GetTitle() || author == books[i].GetAuthor())
                {
                    if (books[i].GetAvailability())
                    {
                        flag = true;
                        data = i;
                        break;

                    }


                }
             
            }
            if (flag)
            {
                books[data].SetAvailablility(false);
                Console.WriteLine("the book is found");
                Console.WriteLine("Data of Book : " );
                Console.WriteLine("------------------");
                Console.WriteLine($"Title : {books[data].GetTitle()}");
                Console.WriteLine($"Author : {books[data].GetAuthor()}");
                Console.WriteLine($"Isbn : {books[data].GetIsbn()}");
                Console.WriteLine($"Availability Now  : {books[data].GetAvailability()}");
                Console.WriteLine("------------------");


            }
           else
            {
               Console.WriteLine("the book is not in the library !!!");
            }

        }
        public void ReturnBook(string title, string author = "")
        {
            bool flag = false;
            int data = 0;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].GetTitle()==title || books[i].GetAuthor()==author)
                {
                    if (books[i].GetAvailability()==false)
                    {
                        books[i].SetAvailablility(true);
                        flag=true;
                        data = i;
                        break;
                    }


                }
              
            }
            if (flag)
            {
                Console.WriteLine($"you returned the book successfully ,{books[data].GetAvailability()}  ");
            }
            else
            {
                Console.WriteLine("the book is not borrowed");
            }

        }

    }
}
