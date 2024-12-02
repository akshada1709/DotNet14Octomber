using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IUserRepository
    {
        int Register(User user);
        User Login(string email, string password);
    }
}
