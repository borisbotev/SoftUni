

namespace Panda.Services
{
    using Panda.Data.Models;
    using System.Collections.Generic;
    public interface IUserService
    {
        string CreateUser(string username, string email, string password);

        User GetUserOrNull(string username, string password);

        IEnumerable<string> GetUsernames();
    }
}
