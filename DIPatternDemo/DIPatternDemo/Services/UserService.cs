using DIPatternDemo.Models;
using DIPatternDemo.Repositories;
using NuGet.Protocol.Core.Types;

namespace DIPatternDemo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;

        public UserService(IUserRepository repo)
        {
          this.repo = repo;
        }
        public bool Login(string email, string password)
        {
            return repo.ValidateUser(email, password);
        }

        public int Register(User user)
        {
            var existingUser = repo.GetUserByEmail(user.Email);
            if (existingUser != null)
            {
                throw new Exception("Email already exists!");
            }
            return repo.AddUser(user);
        }
    }
}
