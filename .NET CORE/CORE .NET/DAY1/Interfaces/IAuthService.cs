using DAY1.DTO;
using DAY1.Model;

namespace DAY1.Interfaces
{
    public interface IAuthService
    {
        Task<User?> RegisterUser(UserDto user);
        Task<string> LoginUser(LoginDto user);
    }
}
