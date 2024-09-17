using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryServices
    {
        
        BookCategoryRepository _repo = new();
        public List<BookCategory> GetCateroty()
        {
            return _repo.GetBookCategory();
        }
    }
}
