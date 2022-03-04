using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.CommonLayer.Model
{
    
    public class ReadInformationResponse
    {
        public bool IsSuccess { get; set; } 
        public string Message { get; set; }
        public List<ReadInformation> readInformation { get; set; }
    }

    public class ReadInformation
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }

    public class ReadInformationByIdRequest
    {
        [Required]
        public int Id { get; set; }
    }

    public class ReadInformationByIdResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ReadInformation readInformation { get; set; }
    }
}
