using Application.Repository;
using Domain.Entity;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryImpl
{
    public class IBookRepositoryImpl : IBookRepository
    {
        private readonly DBaseContext Db;

        public IBookRepositoryImpl (DBaseContext Db)
        {
            this.Db = Db;
        }

        public string AddBook(Book book)
        { try
            {
                Db.Books.Add(book);
                Db.SaveChanges();
            }
            
            catch (Exception ex)
            {
                return book.BookName + "  Exception --> " + ex.Message;
            }

            return book.BookName;
        }

        public string DeleteBook(int Id)
        {
            var RemovedBook = Db.Books.FirstOrDefault(x => x.BookId == Id);
            Db.Books.Remove(RemovedBook);
            Db.SaveChanges();
            return "Book has deleted";
        }

        public IList<Book> GetAll()
        {
            return Db.Books.ToList();
        }

        public Book GetBookById(int Id)
        {
            return Db.Books.FirstOrDefault(x => x.BookId == Id);
        }

        public string UpdateBook(Book book)
        {
            Db.Books.Update(book);
            Db.SaveChanges();
            return "Book has Updated";
        }
    }
}
