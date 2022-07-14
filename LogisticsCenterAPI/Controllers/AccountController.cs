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

                account.Supplier = accountDTO.Supplier;
                account.No_Invoice = accountDTO.No_Invoice;
                account.Supplier = accountDTO.Supplier;
                account.ReceptionDate = accountDTO.ReceptionDate;
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
    }

}
