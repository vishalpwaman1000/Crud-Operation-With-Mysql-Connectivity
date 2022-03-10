using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.CommonLayer.Model
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage ="UserName Is Mandetory")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password Is Mandetory")]
        public string Password { get; set; }
    }

    public class UserLoginResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public UserInformation data { get; set; }
        public string Token { get; set; }
    }

    public class UserInformation
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
