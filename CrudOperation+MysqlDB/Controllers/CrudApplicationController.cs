using CrudOperation_MysqlDB.CommonLayer.Model;
using CrudOperation_MysqlDB.RepositoryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CrudApplicationController : ControllerBase
    {
        public readonly ICrudApplicationSL _crudApplicationSL;
        public readonly ILogger<CrudApplicationController> _logger;
        public CrudApplicationController(ICrudApplicationSL crudApplicationSL, ILogger<CrudApplicationController> logger)
        {
            _crudApplicationSL = crudApplicationSL;
            _logger = logger;
        }

        [HttpPost]
        //[Route("AddUserInformation")]
        public async Task<IActionResult> RegisterUser(RegisterUserRequest request)
        {
            RegisterUserResponse response = new RegisterUserResponse();
            _logger.LogInformation($"RegisterUser Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.RegisterUser(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"RegisterUser Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();
            _logger.LogInformation($"UserLogin Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.UserLogin(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"RegisterUser Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpPost]
        //[Route("AddUserInformation")]
        public async Task<IActionResult> AddInformation(AddInformationRequest request)
        {
            AddInformationResponse response = new AddInformationResponse();
            _logger.LogInformation($"AddInformation Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.AddInformation(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"AddInformation Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpGet]
        //[Route("ReadInformation")]
        public async Task<IActionResult> ReadAllInformation()
        {
            ReadInformationResponse response = new ReadInformationResponse();
            try
            {

                response = await _crudApplicationSL.ReadAllInformation();
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"ReadAllInformation Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message, Data = response.readInformation });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
        }

        [HttpPost]
        //[Route("ReadInformationById")]
        public async Task<IActionResult> ReadInformationById(ReadInformationByIdRequest request)
        {
            ReadInformationByIdResponse response = new ReadInformationByIdResponse();
            _logger.LogInformation($"ReadInformationById Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.ReadInformationById(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"ReadInformationById Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message, Data = response.readInformation });
        }

        [HttpPut]
        //[Route("UpdateAllInformationById")]
        public async Task<IActionResult> UpdateAllInformationById(UpdateAllInformationByIdRequest request)
        {
            UpdateAllInformationByIdResponse response = new UpdateAllInformationByIdResponse();
            _logger.LogInformation($"UpdateAllInformationById Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.UpdateAllInformationById(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"UpdateAllInformationById Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpPatch]
        //[Route("UpdateOneInformationById")]
        public async Task<IActionResult> UpdateOneInformationById(UpdateOneInformationByIdRequest request)
        {
            UpdateOneInformationByIdResponse response = new UpdateOneInformationByIdResponse();
            _logger.LogInformation($"UpdateOneInformationById Api Calling : {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.UpdateOneInformationById(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"UpdateOneInformationById Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

        [HttpDelete]
        //[Route("DeleteInformationByID")]
        public async Task<IActionResult> DeleteInformationByID(DeleteInformationByIDRequest request)
        {
            DeleteInformationByIDResponse response = new DeleteInformationByIDResponse();
            _logger.LogInformation($"DeleteInformationByID Api Calling {JsonConvert.SerializeObject(request)}");
            try
            {

                response = await _crudApplicationSL.DeleteInformationByID(request);
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"DeleteInformationByID Controller Error => {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });

        }

        [HttpPost]
        //[Route("DeleteAllInformation")]
        public async Task<IActionResult> GetAllDeleteInformation()
        {
            GetAllDeleteInformationResponse response = new GetAllDeleteInformationResponse();
            _logger.LogInformation($"GetAllDeleteInformation APi Calling");
            try
            {

                response = await _crudApplicationSL.GetAllDeleteInformation();
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message, Data=response.deletedInformation });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"GetAllDeleteInformation Controller Error {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message, Data=response.deletedInformation });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message, Data=response.deletedInformation });
        }

        [HttpPost]
        //[Route("DeleteAllInformation")]
        public async Task<IActionResult> DeleteAllActiveInformation()
        {
            DeleteAllInformationResponse response = new DeleteAllInformationResponse();
            _logger.LogInformation($"DeleteAllInformation APi Calling");
            try
            {

                response = await _crudApplicationSL.DeleteAllInActiveInformation();
                if (!response.IsSuccess)
                {
                    return BadRequest(new { IsSuccess = response.IsSuccess, Message = response.Message });
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                _logger.LogError($"DeleteAllInActiveInformation Controller Error {ex.Message}");
                return BadRequest(new { IsSuccess = response.IsSuccess, Message = ex.Message });
            }

            return Ok(new { IsSuccess = response.IsSuccess, Message = response.Message });
        }

    }
}
