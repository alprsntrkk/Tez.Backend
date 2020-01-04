using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class UserInfo
    {
        public  AccessToken accesToken { get; set; }
        public  User userInfo { get; set; }
    }
}
