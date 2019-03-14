using System.Threading.Tasks;
using SampleDotNet.Core.Domain;

namespace SampleDotNet.Services.Authentication
{
    public interface IAuthRepository
    {
        Task<User> Register(User user , string password);
        Task<User> Login(string username , string password);
        Task<bool> UserExists(string username);
    }
}