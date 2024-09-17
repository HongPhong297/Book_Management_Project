using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext? _context;

        public UserAccount? GetUserAccount(string email, string pass)
        {
            _context = new();
            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x) 
            //{
            //    if(x.Email == email && x.Password == pass) 
            //        return true;
            //    return false;
            //});

            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == pass);
            
        }
    }
}
