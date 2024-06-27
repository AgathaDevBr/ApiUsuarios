using ApiUsuarios.Domain.Interfaces;
using ApiUsuarios.Domain.Models;
using ApiUsuarios.Infra.Data.Contexts;
using System.Linq;

namespace ApiUsuarios.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users?.Add(user);
            _context.SaveChanges();
        }

        public User Get(string userName)
        {
            return _context.Users
                .FirstOrDefault(u => u.UserName.Equals(userName));
        }

        public User Get(string userName, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.UserName.Equals(userName)
                && u.Password.Equals(password));
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
