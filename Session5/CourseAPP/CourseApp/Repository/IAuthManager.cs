using CourseApp.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace CourseApp.Repository
{
    public interface IAuthManager
    {

      Task< IEnumerable<IdentityError>>RegisterUser(ApiUserDto user);
        Task<AuthResponseDto> Login(LoginDto logindto);

        Task<string> CraeteRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);

    }
}
