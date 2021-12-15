using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCore.Models;

namespace Trainingapplication.Books
{
    public class BookService : IBookService
    {
        public IEnumerable<Book> Get()
        {
            for (int i = 0; i < 5; i++)
                yield return new Book { Id = i, ISBN = $"XXX-{i}{i}", Name = $"Book {i}", Author = $"Author {i}" };

        }

    }
}
