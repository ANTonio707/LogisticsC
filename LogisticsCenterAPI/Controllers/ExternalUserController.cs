using LogisticsCenterAPI.Repository.ExternalUserRepository;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalUserController : ControllerBase
    {
        private readonly IExternalUserRepository _externalUserRepository;
        public ExternalUserController(IExternalUserRepository externalUserRepository)
        {
            this._externalUserRepository = externalUserRepository;
        }
        [HttpGet, Route("Get")]
        public async Task<ActionResult<External_User>> Get() 
        {
            var webResonse = new Response<List<External_User>>();
            var data = await _externalUserRepository.Get();
            webResonse = new Response<List<External_User>>()
            {
                IsSuccess = true, 
                Message = "The list was returned",
                StatusCode = "OK",
                Body =  data
            };
            return Ok(webResonse);
        }

        [HttpPost, Route("Create")]
        public async Task<ActionResult<External_User>> Create(External_UserDTO external_UserDTO)
        {
            var WebResonse = new Response<External_User>();
            var data = await _externalUserRepository.Create(external_UserDTO);

            WebResonse = new Response<External_User>()
            {
                Message = "The user was create successful",
                StatusCode = "OK",
                IsSuccess = true,
                Body = data
            };
            return Ok(data);
        }

        [HttpPost, Route("Update")]
        public async Task<ActionResult<External_User>> Update(External_UserDTO external_UserDTO) 
        {
            var data = await _externalUserRepository.Update(external_UserDTO);
            return Ok(data);
        }
        
    }
}
