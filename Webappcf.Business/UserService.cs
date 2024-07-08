using System.Collections.Generic;
using System.Linq;
using Webappcf.Data;
using Webappcf.Entities;

namespace Webappcf.Business
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
