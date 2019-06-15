
using Panda.Data.Models;

namespace Panda.Services
{
    public interface IUserService
    {
        string CreateUser(string username, string email, string password);

        User GetUserOrNull(string username, string password);
    }
}
