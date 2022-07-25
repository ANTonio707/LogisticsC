using LogisticsCenterAPI.Models;
using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterAPI.Repository;
using LogisticsCenterAPI.Repository.AccountRepository;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class AccountController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILogger<AccountController> _logger;
        private IAccountRepository _accountRepository;
        readonly IWebHostEnvironment _webHostEnvironment;
      
        public AccountController(
            IAccountRepository accountRepository,
            ILogger<AccountController> logger,
            IWebHostEnvironment env,
            IConfiguration configuration)
        {
            _logger = logger;
            _accountRepository = accountRepository;
            _webHostEnvironment = env;
            _config = configuration;
        }
        [HttpPost, Route("Create")]
        public async Task<ActionResult> Create([FromBody] AccountDTO accountDTO) 
        {
            Account account = new Account();
            try
            {
                var WebResponse = new Response<Invoice>();

                account.SupplierId = accountDTO.SupplierId;
                account.No_Invoice = accountDTO.No_Invoice;
                account.SupplierId = accountDTO.SupplierId;
                account.ReceptionDate = accountDTO.ReceptionDate;
                account.InvoiceSupplierDate = accountDTO.InvoiceSupplierDate;
                account.PaymentDescription = accountDTO.PaymentDescription;
                account.Reference = accountDTO.Reference;
                account.InvoiceFileRute = accountDTO.InvoiceFileRute;
                account.No_FRP = accountDTO.No_FRP;
                account.No_Internal_Invoice = accountDTO.No_Internal_Invoice;
                account.CustomerPayment = accountDTO.CustomerPayment;
                account.CustomerName = accountDTO.CustomerName;
                account.EntranceFee = accountDTO.EntranceFee;
                account.SupplierPayment = accountDTO.SupplierPayment;
                account.CostRate = accountDTO.CostRate;

                var data = await _accountRepository.Create(account);
                return Ok(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("Filter")]
        public async Task<ActionResult> Filter([FromBody] GlobalSearchDTO globalSearchDTO)
        {
            var WebResponse = new Response<List<Account>>();
            string GroupbillersAccess = _config.GetSection("GroupbillersAccess").Value;

            var obj = await _accountRepository.Filter(globalSearchDTO);
            //var claims = User.Claims.ToList();

            WebResponse = new Response<List<Account>>()
            {
                StatusCode = "OK",
                IsSuccess = true,
                Message = "The search was successful",
                Body = obj,
                MetaData = obj.MetaData

            };
            return Ok(WebResponse);

        }

        [HttpPost, Route("GetById")]
        public async Task<ActionResult> GetById(int Id) 
        {
            var WebResponse = new Response<Account>();

            var obj = await _accountRepository.GetById(Id);
            WebResponse = new Response<Account>()
            {
                StatusCode = "OK",
                IsSuccess = true,
                Body = obj
            };
            return Ok(WebResponse);
            
        }
    }

}
