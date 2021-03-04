//Created By Engin Yenice
//enginyenice2626@gmail.com
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);

        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult UserExits(string email);

        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}