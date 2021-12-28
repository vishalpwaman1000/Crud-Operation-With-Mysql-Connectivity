using CrudOperation_MysqlDB.CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.RepositoryLayer
{
    public interface ICrudApplicationSL
    {
        //AddInformation,ReadInformation,ReadInformationById,UpdateAllInformationById,UpdateOneInformationById,DeleteInformationByID,DeleteAllInformation
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
        public Task<ReadInformationResponse> ReadAllInformation();
        public Task<ReadInformationByIdResponse> ReadInformationById(ReadInformationByIdRequest request);
        public Task<UpdateAllInformationByIdResponse> UpdateAllInformationById(UpdateAllInformationByIdRequest request);
        public Task<UpdateOneInformationByIdResponse> UpdateOneInformationById(UpdateOneInformationByIdRequest request);
        public Task<DeleteInformationByIDResponse> DeleteInformationByID(DeleteInformationByIDRequest request);
        public Task<GetAllDeleteInformationResponse> GetAllDeleteInformation();
        public Task<DeleteAllInformationResponse> DeleteAllInActiveInformation();
    }
}
