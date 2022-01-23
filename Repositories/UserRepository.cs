using Jwt_Authentication.Models;

namespace Jwt_Authentication.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "luke_admin", EmailAddress = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke", Surname = "Rogers", Role = "Administrator" },
            new() { Username = "lydia_standard", EmailAddress = "lydia.admin@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" },
        };
    }
}
