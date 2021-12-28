using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.CommonLayer.Model
{
    public class AddInformationRequest
    {
        [Required(ErrorMessage = "UserName Is Mandetory Field")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="EmailId Is Mandetory Field")]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Mobile Number Is Mandetory Field")]
        public string MobileNumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
    }

    public class AddInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
