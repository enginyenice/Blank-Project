//Created By Engin Yenice
//enginyenice2626@gmail.com

using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}