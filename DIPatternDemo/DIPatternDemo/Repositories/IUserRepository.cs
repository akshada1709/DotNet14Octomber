using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IUserRepository
    {
        int AddUser(User user);
        User GetUserByEmail(string email);
        bool ValidateUser(string email, string password);
    }
}
