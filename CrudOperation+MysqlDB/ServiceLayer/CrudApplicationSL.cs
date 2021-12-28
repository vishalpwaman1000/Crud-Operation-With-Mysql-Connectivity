using CrudOperation_MysqlDB.CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.RepositoryLayer
{
    public class CrudApplicationSL : ICrudApplicationSL
    {
        public readonly ICrudApplicationRL _crudApplicationRL;
        public readonly string EmailRegex = @"^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,3})?$";
        public readonly string MobileRegex = @"([1-9]{1}[0-9]{9})$";
        public readonly string GenderRegex = @"^(?:m|male|f|female)$";
        public CrudApplicationSL(ICrudApplicationRL crudApplicationRL)
        {
            _crudApplicationRL = crudApplicationRL;
        }

        public async Task<AddInformationResponse> AddInformation(AddInformationRequest request)
        {
            AddInformationResponse response = new AddInformationResponse();

            if (!(Regex.IsMatch(request.EmailID,EmailRegex)))
            {
                response.IsSuccess = false;
                response.Message = "Invalid EmailID Input";
                return response;
            }

            if(!(Regex.IsMatch(request.MobileNumber,MobileRegex)))
            {
                response.IsSuccess = false;
                response.Message = "Invalid Mobile Number Input";
                return response;
            }

            if (!(Regex.IsMatch(request.Gender.ToLower(), GenderRegex)))
            {
                response.IsSuccess = false;
                response.Message = "Invalid Gender Input. Example : m, M, male, Male, f, F, female, Female";
                return response;
            }

            return await _crudApplicationRL.AddInformation(request);
        }

        public async Task<DeleteAllInformationResponse> DeleteAllInActiveInformation()
        {
            return await _crudApplicationRL.DeleteAllInActiveInformation();
        }

        public async Task<DeleteInformationByIDResponse> DeleteInformationByID(DeleteInformationByIDRequest request)
        {
            return await _crudApplicationRL.DeleteInformationByID(request);
        }

        public async Task<GetAllDeleteInformationResponse> GetAllDeleteInformation()
        {
            return await _crudApplicationRL.GetAllDeleteInformation();
        }

        public async Task<ReadInformationResponse> ReadAllInformation()
        {
            return await _crudApplicationRL.ReadAllInformation();
        }

        public async Task<ReadInformationByIdResponse> ReadInformationById(ReadInformationByIdRequest request)
        {
            return await _crudApplicationRL.ReadInformationById(request);
        }

        public async Task<UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateAllInformationByIdRequest request)
        {
            return await _crudApplicationRL.UpdateAllInformationById(request);
        }

        public async Task<UpdateOneInformationByIdResponse> UpdateOneInformationById(UpdateOneInformationByIdRequest request)
        {
            return await _crudApplicationRL.UpdateOneInformationById(request);
        }
    }
}
