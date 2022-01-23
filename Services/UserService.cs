using Jwt_Authentication.Models;
using Jwt_Authentication.Repositories;

namespace Jwt_Authentication.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o=>o.Username.Equals
            (userLogin.Username, StringComparison.OrdinalIgnoreCase) && o.Password.Equals
            (userLogin.Password));

            return user;
        }
    }
}
