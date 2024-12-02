using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) 
        {
             
        }
        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public int Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
