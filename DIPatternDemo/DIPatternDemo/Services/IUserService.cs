using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IUserService
    {
        int Register(User user);
        bool Login(string email, string password);
    }
}
