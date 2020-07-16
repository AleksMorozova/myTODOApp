using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public interface IBooksService {
        public List<Book> getAllBooks();

    }
    public class BooksService: IBooksService
    {
        IBooksRepository booksRepository;
        public BooksService(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        public List<Book> getAllBooks() {
            return booksRepository.getAllBooks();
        }
    }
}
