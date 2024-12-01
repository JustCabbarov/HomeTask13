using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14
{
    internal class Library
    {
        List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get => books[index];
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string Name)
        {
            var wantedBooks = books.FindAll(x => x.Name == Name);
            return wantedBooks;
        }

        public Book FindBookByCode(string Code)
        {
            var wantedbook2 = books.Find(x => x.Code == Code);
            return wantedbook2;
        }

        public void RemoveAllBooksByNme(string name)
        {
            books.RemoveAll(x => x.Name == name);
        }

        public List <Book> SearchBooks(string value)
        {
            List<Book> wantedbook2 = new List<Book>();
            foreach (var book in books)
            {
                if(book.Code == value|| book.OuthorName== value||book.OuthorName== value)
                {
                    wantedbook2.Add(book);
                    return wantedbook2;
                }
            }
            return null;

        }

        public List<Book> FindAllBooksByPageCountRange(int min ,int max)
        {
            List<Book> wantedbook=new List<Book>();
            foreach (var book in books)
            {
                if (book.PageCount>min && book.PageCount < max)
                {
                    wantedbook.Add(book);
                    return wantedbook;
                }
            }
            return null;
        }

        public void RemoveBookByCode(string code)
        {
            books.RemoveAll(x=>x.Code == code);
        }
    }
}
