using AutoMapper;
using LogisticsCenterAPI.Repository.AuthRepository;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Controllers.Authetication
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class AuthController : ControllerBase
    {
        private IAuthRepository _repo;
        IMapper _mapper;
        IConfiguration _configuration;
    
        public AuthController(IAuthRepository repo, IMapper mapper, IConfiguration configuration )
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration; 
        }


        //[HttpPost, Route("Login")]
        //public async Task<ActionResult<Response<UserLoginDTO>>> Login([FromBody] UserLoginDTO user)
        //{
        //    var WebResponseLogin = new Response<UserLoginDTO>();
        //    var data = await _repo.LoginWithActDirect(user.UserName, user.Password);
        //    var userDTO = _mapper.Map<UserLoginDTO>(data);

        //    if (userDTO != null)
        //    {
        //        var claim = new Claim(ClaimTypes.Name, userDTO.UserName);
        //        var claimsIdentity = new ClaimsIdentity(new[] { claim }, "ServerAuth");
        //        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        //        await HttpContext.SignInAsync(claimsPrincipal);
        //    }

        //    //var claim = new Claim()
        //    if (data == null)
        //    {
        //        WebResponseLogin = new Response<UserLoginDTO>()
        //        {
        //            StatusCode = "INVALID",
        //            Message = "The user is not valid",
        //            Body = userDTO
        //        };
        //    }
        //    WebResponseLogin = new Response<UserLoginDTO>()
        //    {
        //        StatusCode = "OK",
        //        Message = "The user is valid",
        //        Body = userDTO
        //    };
        //    return await Task.FromResult(WebResponseLogin);
        //}


        [HttpPost, Route("Login")]
        public async Task<ActionResult<Response<UserToken>>> Login([FromBody] UserLoginDTO user)
        {
            var dataToken = new UserToken();
            var WebResponseLogin = new Response<UserToken>();
            var data = await _repo.LoginWithActDirect(user.UserName, user.Password);
            if (data != null)
            {
                dataToken = BuildToken(data);
            }
 
            if (data == null)
            {
                WebResponseLogin = new Response<UserToken>()
                {
                    StatusCode = "INVALID",
                    Message = "The user is not valid",
                    Body = dataToken
                };
                return await Task.FromResult(WebResponseLogin);
            } 
           
            WebResponseLogin = new Response<UserToken>()
            {
                StatusCode = "OK",
                Message = "The user is valid",
                Body = dataToken
            };
           
            return await Task.FromResult(WebResponseLogin);
        }


        //[HttpGet, Route("GetCurrentUser")]
        //public async Task<ActionResult<UserLoginDTO>> GetCurrentUser() 
        //{
        //    UserLoginDTO Currentuser = new UserLoginDTO();

        //    if (User.Identity.IsAuthenticated)
        //    {
        //        Currentuser.UserName = User.FindFirstValue(ClaimTypes.Name);
        //    }
        //     return await Task.FromResult(Currentuser);
        //}


        //[HttpGet, Route("Logout")]
        //public async Task<ActionResult<string>>LogOut()
        //{
        //    await HttpContext.SignOutAsync();
        //    return "Success";
        //}

        private UserToken BuildToken(User userInfo)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Username),
                new Claim(ClaimTypes.Name, userInfo.Username),
                new Claim("FullName", userInfo.FullName),
                new Claim("JobFunction", userInfo.JobFunction),
                new Claim("FirstName", userInfo.FirstName),
                new Claim("GroupAccess", userInfo.GroupAccess),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tiempo de expiración del token. En nuestro caso lo hacemos de una hora.
            var expiration = DateTime.UtcNow.AddDays(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
