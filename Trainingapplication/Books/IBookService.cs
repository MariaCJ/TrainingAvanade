using System.Collections.Generic;
using TrainingCore.Models;

namespace Trainingapplication.Books
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
    }
}