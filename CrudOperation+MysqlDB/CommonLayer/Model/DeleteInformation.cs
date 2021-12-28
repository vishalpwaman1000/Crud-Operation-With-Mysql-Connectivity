using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.CommonLayer.Model
{
    public class DeleteInformationByIDRequest
    {
        [Required]
        public int Id { get; set; }
    }

    public class DeleteInformationByIDResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class DeleteAllInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<DeletedInformation> deletedInformation { get; set; }
    }

    public class DeletedInformation
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetAllDeleteInformationResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<DeletedInformation> deletedInformation { get; set; }
    }

  
}
