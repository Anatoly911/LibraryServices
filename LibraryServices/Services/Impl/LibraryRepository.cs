using LibraryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryServices.Services.Impl
{
    public class LibraryRepository : ILibraryRepositoryService
    {
        private readonly ILibraryDatabaseContextService _dbContext;
        public LibraryRepository(ILibraryDatabaseContextService dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Book> GetByTitle(string title)
        {
            try
            {
                return _dbContext.Books
                    .Where(book => book.Title.ToLower().Contains(title.ToLower()))
                    .ToList();
            }
            catch
            {
                return new List<Book>();
            }
        }
        public IList<Book> GetByAuthor(string authorName)
        {
            try
            {
                return _dbContext.Books.Where(book =>
                    book.Authors.Where(author => author.Name.ToLower().Contains(authorName.ToLower())).Count() > 0).ToList();
            }
            catch
            {
                return new List<Book>();
            }
        }
        public IList<Book> GetByCategory(string category)
        {
            try
            {
                return _dbContext.Books
                    .Where(book => book.Category.ToLower().Contains(category.ToLower()))
                    .ToList();
            }
            catch
            {
                return new List<Book>();
            }
        }
        public int? Add(Book item)
        {
            throw new NotImplementedException();
        }
        public int Delete(Book item)
        {
            throw new NotImplementedException();
        }
        public Book GetById(string id)
        {
            throw new NotImplementedException();
        }
        public int Update(Book item)
        {
            throw new NotImplementedException();
        }
        public IList<Book> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}