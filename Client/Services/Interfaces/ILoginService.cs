using Albatross.Client.Services.Dto;
using Albatross.Shared;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResult> AdminLoginAsync(LoginDto loginDto);

        Task<LoginResult> UserLoginAsync(LoginDto loginDto);

        bool IsLoggedIn { get; }
    }
}
