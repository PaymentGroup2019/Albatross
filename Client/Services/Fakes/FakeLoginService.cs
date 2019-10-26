using Albatross.Client.Services.Dto;
using Albatross.Client.Services.Interfaces;
using Albatross.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Fakes
{
    public class FakeLoginService : ILoginService
    {
        public bool IsLoggedIn { get; private set; }

        public async Task<LoginResult> AdminLoginAsync(LoginDto loginDto)
        {
            var result = new LoginResult();

            if (loginDto.UserName == "Admin" && loginDto.Password == "123qwe")
            {
                result.IsSuccessful = true;

                IsLoggedIn = true;
            }
            else
            {
                IsLoggedIn = false;
            }

            await Task.Delay(1000);

            return result;
        }

        public async Task<LoginResult> UserLoginAsync(LoginDto loginDto)
        {
            var result = new LoginResult();

            if (loginDto.UserName == "User" && loginDto.Password == "123qwe")
            {
                result.IsSuccessful = true;

                IsLoggedIn = true;
            }
            else
            {
                IsLoggedIn = false;
            }

            await Task.Delay(1000);

            return result;
        }
    }
}
