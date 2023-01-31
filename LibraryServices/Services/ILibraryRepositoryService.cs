using LibraryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Services
{
    public interface ILibraryRepositoryService : IRepository<Book, string>
    {
        IList<Book> GetByTitle(string title);
        IList<Book> GetByAuthor(string authorName);
        IList<Book> GetByCategory(string category);
    }
}
