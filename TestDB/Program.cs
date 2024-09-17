using Repositories;
using Repositories.Entities;
using System.Threading.Channels;

namespace TestDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BookManagementDbContext db = new BookManagementDbContext();
            List<BookCategory> arr = db.BookCategories.ToList();
            
            arr.ForEach(us => Console.WriteLine($"{us.BookCategoryId}| {us.BookGenreType}"));
                
        }
    }
    // TEST GIT
    // kiểm tra git 2
}
