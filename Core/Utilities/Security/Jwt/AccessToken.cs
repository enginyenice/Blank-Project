//Created By Engin Yenice
//enginyenice2626@gmail.com

using System;

namespace Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}