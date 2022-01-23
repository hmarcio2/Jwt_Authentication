using Jwt_Authentication.Models;

namespace Jwt_Authentication.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
