using DIPatternDemo.Data;
using DIPatternDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPatternDemo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) 
        {
             this.db = db;
        }

        public int AddUser(User user)
        {
            db.Users1?.Add(user);
            return db.SaveChanges();
        }

        public User GetUserByEmail(string email)
        {
            return db.Users1?.FirstOrDefault(u => u.Email == email);
        }

        public bool ValidateUser(string email, string password)
        {
            var user = GetUserByEmail(email);
            return user != null && user.Password == password;
        }
    }
}
