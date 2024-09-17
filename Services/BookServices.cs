using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace Services

{
    public class BookServices
    {
        public bool _checkdup { get; set; } = false;
        private BookRepository? _repo;
        public List<Book> GetAllBook()
        {
            _repo = new BookRepository();
            return _repo.GetBook();
        }

        // hàm tạo mới sách , lấy sách từ ui, 

        public void AddBookFromUI(Book book)
        {
            _repo = new BookRepository();
            //_repo.AddBook(book);
            try
            {
                // Assume 'context' is your DbContext and 'newBook' is the book entity you want to add
                _repo.AddBook(book);
                
            }
            //catch (DbUpdateException ex)
            //{
            //    // Check if the exception is due to a primary key violation
            //    if (ex.InnerException?.InnerException is SqlException sqlEx && sqlEx.Number == 2627)
            //    {
            //        // Handle the primary key violation (duplicate key)
            //        return;
            //        // Optionally, you can prompt the user to enter a new ID or take other appropriate action
            //    }
            //    else
            //    {
            //        // Handle other exceptions
            //        throw;
            //    }
            //}
            catch (Exception ex) 
            {
                _checkdup = true;
                return ;
            }

        }

        public void RemoveBookFromUI(Book book)
        {
            _repo = new BookRepository();
            _repo.RemoveBook(book);
        }

        public void UpdateBookFromUI(Book book)
        {
            _repo = new BookRepository();
            _repo.UpdateBook(book);
        }
    }
}
