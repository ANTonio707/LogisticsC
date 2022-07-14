using AutoMapper;
using LogisticsCenterAPI.Data;
using LogisticsCenterAPI.Models.Pagination;
using LogisticsCenterAPI.Repository;
using LogisticsCenterAPI.Repository.InvoiceRository;
using LogisticsCenterMODELS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks; 

namespace LogisticsCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class InvoiceController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILogger<InvoiceController> _logger;
        private I_InvoiceRepository _InvoiceRepository;
        readonly IWebHostEnvironment _webHostEnvironment;
        private ApplicationDbContext db;
        private readonly UTLS utls;

        private IMapper _mapper;

        public InvoiceController(
            I_InvoiceRepository invoiceRepository,
            ILogger<InvoiceController> logger,
            IWebHostEnvironment env,
            IConfiguration configuration,
            ApplicationDbContext applicationDbContext, UTLS tLS,
            IMapper mapper)
        {
            _logger = logger;
            _InvoiceRepository = invoiceRepository;
            _webHostEnvironment = env;
            _config = configuration;
            db = applicationDbContext;
            this.utls = tLS;
            _mapper = mapper;
        }
        #region
        //[HttpGet]
        //public async Task<ActionResult> GetInvoices([FromQuery] PaginationParameters paginationParameters)
        //{

        //    try
        //    {
        //        _logger.LogInformation($"function--->GetInvoices      | PageNumber: {paginationParameters.PageNumber}   | PageSize: {paginationParameters.PageSize}");
        //        var data = await _InvoiceRepository.GetInvoices(paginationParameters);
        //        var WebResponse = new Response<List<Invoice>>() {
        //            StatusCode = "OK",
        //            IsSuccess = true,
        //            Message = "List was returned",
        //            Body = data
        //        };
        //        return Ok(WebResponse);

        //    }
        //    catch (System.Exception ex)
        //    {
        //        _logger.LogCritical("function---> GetInvoices      | ", ex);
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //          new { message = ex.Message, IsSuccess = false, StatusCode = "INTERNAL_SERVER_ERROR" });
        //    }
        //}

        //[HttpGet("{NoInvoice}")]
        //public Response<Invoice> GetByNoInvoice(string NoInvoice)
        //{
        //    try
        //    {
        //        if (NoInvoice == null)
        //        {
        //            return null;
        //        }
        //        _logger.LogInformation($"function--->GetInvoiceByNoInvoice          | Search: {NoInvoice}");

        //        return _InvoiceRepository.GetByNoInvoice(NoInvoice);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        _logger.LogCritical("function--->GetInvoiceByNoInvoice          | ", ex);
        //        return default;
        //    }
        //}
        //Create method
        //[httppost("create")]
        //public async task<actionresult> create([frombody] addinvoice invoice)
        //{
        //    //utls utls = new utls(_config, db);
        //    invoice inv = new invoice();
        //    var pathfolderresourse = _config.getsection("pathfolderresourse").value;
        //    var fullpathfile = pathfolderresourse + invoice.supplier;
        //    try
        //    {
        //        if (utls.isvalidrecord(invoice.supplier, invoice.no_invoice))
        //        {
        //            if (!directory.exists(fullpathfile))
        //            {
        //                directory.createdirectory(fullpathfile);
        //            }
        //            string filename = invoice.uploadedfile.filename;


        //            if (utls.isvalidfile(filename))
        //            {
        //                string path = utls.fileconvert(invoice.uploadedfile, invoice.no_invoice, fullpathfile).trim().toupper();
        //                inv.no_invoice = invoice.no_invoice.trim().toupper();
        //                inv.supplier = invoice.supplier.trim().toupper();
        //                inv.paymentdescription = invoice.paymentdescription.trim().toupper();
        //                inv.reference = invoice.reference.trim().toupper();
        //                inv.invoicesupplierdate = convert.todatetime(invoice.invoicesupplierdate);
        //                inv.invoicefilerute = path.trim().toupper();
        //                if (invoice == null)
        //                {
        //                    return badrequest(modelstate);
        //                }
        //                if (!modelstate.isvalid)
        //                {
        //                    return badrequest(modelstate);
        //                }
        //                await _invoicerepository.create(inv);
        //                return ok();
        //            }
        //        }
        //        return badrequest();
        //    }
        //    catch (exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

        [HttpPost, Route("GetByNoinvoiceAndSupplier")]
        public Invoice GetByNoinvoiceAndSupplier(InvoiceDTO invoiceDTO)
        {
            Invoice Inv = new Invoice();
            //Inv.No_Invoice = invoiceDTO.No_Invoice;
            //Inv.Supplier = invoiceDTO.Supplier;
            return _InvoiceRepository.GetByNoinvoiceAndSuppler(invoiceDTO.No_Invoice, invoiceDTO.Supplier);
        }



        [HttpPost, Route("GetInvoiceById")]
        public async Task<ActionResult> GetInvoiceById([FromBody] int id)
        {
            var data = await _InvoiceRepository.GetById(id);
            var WebResponse = new Response<InvoiceDTO>()
            {
                StatusCode = "OK",
                IsSuccess = true,
                Message = " ",
                Body = data
            };
           
            return Ok(WebResponse);
        }

        [HttpPost, Route("GetAllInvoices")]
        [Authorize]
        public async Task<ActionResult> GetAllInvoices([FromBody] GlobalSearchDTO globalSearchDTO)
        {

            string GroupbillersAccess = _config.GetSection("GroupbillersAccess").Value;
            try
            {
                //_logger.LogInformation($"function--->GetInvoices      | PageNumber: {paginationParameters.PageNumber}   | PageSize: {paginationParameters.PageSize}");
                PaginationParameters pagination = new PaginationParameters()
                {
                    PageSize = 50,
                    PageNumber = 1
                };  
                var claims = User.Claims.ToList();

                var UserTest = claims.Any(x => x.Type == "GroupAccess" && x.Value == GroupbillersAccess);
                if (UserTest)
                {
                   var dataTest =  db.Invoice.Where(x => x.status == false);
                    
                    var WebResponsetest = new Response<List<Invoice>>()
                    {
                        StatusCode = "OK",
                        IsSuccess = true,
                        Message = "List was returned",
                        Body = dataTest.ToList()
                    };
                    return Ok(WebResponsetest);
                }


                var data = await _InvoiceRepository.GetInvoices(pagination);

                
                var WebResponse = new Response<List<Invoice>>()
                {
                    StatusCode = "OK",
                    IsSuccess = true,
                    Message = "List was returned",
                    Body = data
                };
                return Ok(WebResponse);

            }
            catch (System.Exception ex)
            { 
                return StatusCode(StatusCodes.Status500InternalServerError,
                  new { message = ex.Message, IsSuccess = false, StatusCode = "INTERNAL_SERVER_ERROR" });
            }
        }
        [HttpPost, Route("AddInvoice")]
        public async Task<ActionResult> Create([FromBody] InvoiceDTO invoiceDTO)
        {
            Invoice Inv = new Invoice(); 
            try
            {
                var WebResponse = new Response<Invoice>();
                if (utls.IsValidRecord(invoiceDTO.Supplier, invoiceDTO.No_Invoice))
                {
                    if (invoiceDTO.FileName != null)
                    {
                        
                        
                        if (invoiceDTO.FileName != null)
                        {
                            var PathFolderResourse = _config.GetSection("PathFolderResourse").Value;
                            var fullPathFile = PathFolderResourse + $"{invoiceDTO.Supplier}/{DateTime.Now.ToString("yyyy")}/{DateTime.Now.ToString("MM")}";
                            if (!Directory.Exists(fullPathFile))
                            {
                                Directory.CreateDirectory(fullPathFile);
                            }
                            string fileName = invoiceDTO.FileName;


                            if (!utls.IsValidFile(fileName))
                            {
                                var WebResponseFileInvalid = new Response<Invoice>()
                                {
                                    StatusCode = "DATA_INVALID",
                                    IsSuccess = false,
                                    Message = "The file is not valid"
                                };
                                return Ok(WebResponseFileInvalid);
                            }
                            Inv.InvoiceFileRute = utls.FileConvert(invoiceDTO, fullPathFile);
                        } 
                    }
                    Inv.No_Invoice = invoiceDTO.No_Invoice.Trim().ToUpper();
                    Inv.Supplier = invoiceDTO.Supplier.Trim().ToUpper();
                    Inv.PaymentDescription = invoiceDTO.PaymentDescription.Trim().ToUpper();
                    Inv.Reference = invoiceDTO.Reference.Trim().ToUpper();
                    Inv.ReceptionDate = invoiceDTO.ReceptionDate;
                    Inv.InvoiceSupplierDate = Convert.ToDateTime(invoiceDTO.InvoiceSupplierDate);
                   
                    if (invoiceDTO == null)
                    {
                        return BadRequest(ModelState);
                    }
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }
                    var data = await _InvoiceRepository.Create(Inv);

                    WebResponse = new Response<Invoice>()
                    {
                        StatusCode = "OK",
                        IsSuccess = true,
                        Message = "The record was created",
                        Body = data
                    };
                    return Ok(WebResponse);
                }
                WebResponse = new Response<Invoice>()
                {
                    StatusCode = "DATA_INVALID",
                    IsSuccess = true,
                    Message = "The invoice is not valid"    
                };

                return Ok(WebResponse);
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }

        [HttpPut, Route("Update")]
        public async Task<ActionResult> Update([FromBody] InvoiceDTO invoiceDTO)
        {
            Invoice Inv = new Invoice();
            
            try
            {
                if (invoiceDTO.FileName != null)
                {
                    var PathFolderResourse = _config.GetSection("PathFolderResourse").Value;
                    var fullPathFile = PathFolderResourse + $"{invoiceDTO.Supplier}/{DateTime.Now.ToString("yyyy")}/{DateTime.Now.ToString("MM")}";
                    if (!Directory.Exists(fullPathFile))
                    {
                        Directory.CreateDirectory(fullPathFile);
                    }
                    string fileName = invoiceDTO.FileName;

                    if (!utls.IsValidFile(fileName))
                    {
                        var WebResponseFileInvalid = new Response<Invoice>()
                        {
                            StatusCode = "DATA_INVALID",
                            IsSuccess = false,
                            Message = "The file is not valid"
                        };
                        return Ok(WebResponseFileInvalid);
                    }
                    string path = utls.FileConvert(invoiceDTO, fullPathFile);
                    Inv.InvoiceFileRute = path.Trim().ToUpper();
                }

                Inv.InvoiceId = invoiceDTO.InvoiceId;
                Inv.No_Invoice = invoiceDTO.No_Invoice.Trim().ToUpper();
                Inv.Supplier = invoiceDTO.Supplier.Trim().ToUpper();
                Inv.PaymentDescription = invoiceDTO.PaymentDescription.Trim().ToUpper();
                Inv.Reference = invoiceDTO.Reference.Trim().ToUpper();
                Inv.InvoiceSupplierDate = Convert.ToDateTime(invoiceDTO.InvoiceSupplierDate);
                Inv.ReceptionDate = Convert.ToDateTime(invoiceDTO.ReceptionDate);

                if (invoiceDTO == null)
                {
                    return BadRequest(ModelState);
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var data = await _InvoiceRepository.Update(Inv);

                var WebResponse = new Response<Invoice>()
                {
                    StatusCode = "OK",
                    IsSuccess = true,
                    Message = "The record was update",
                    Body = data
                };
                return Ok(WebResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new { message = ex.Message, IsSuccess = false, StatusCode = "INTERNAL_SERVER_ERROR" });
            }
        }

        [HttpPost, Route("ValitedExistenceInvoice")]

        public async Task<ActionResult> ValitedExistenceInvoice(InvoiceDTO invoice) 
        {
            try
            {
                Invoice inv = new Invoice();

               

                inv.Supplier = invoice.Supplier;
                inv.No_Invoice = invoice.No_Invoice;
                var obj = await _InvoiceRepository.ValitedExistenceInvoice(inv);
               

                var WebResponse = new Response<Invoice>();
                if (obj == false)
                {
                    WebResponse = new Response<Invoice>()
                    {
                        StatusCode = "OK",
                        IsSuccess = true,
                        Message = "The Invoice is valid"
                    };
                    return Ok(WebResponse);
                }
                WebResponse = new Response<Invoice>()
                {
                    StatusCode = "OK",
                    IsSuccess = false,
                    Message = "The invoice alredy exist"
                };
                return Ok(WebResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          new { message = ex.Message, IsSuccess = false, StatusCode = "INTERNAL_SERVER_ERROR" });
            }
        }
        //[HttpPost, Route("GetByAllField")]
        //public async Task<ActionResult> GetByAllField(string InvoiceField) 
        //{
        //    var data = await _InvoiceRepository.SearchByAllField(InvoiceField);
        //    var WebResponse = new Response<List<Invoice>>()
        //    {
        //        StatusCode = "OK",
        //        IsSuccess = true,
        //        Message = "The search was successful",
        //        Body = data
        //    };
        //    return Ok(WebResponse);
        //}
        [HttpPost, Route("Filter")]
        public async Task<ActionResult> GetByAllField([FromBody] GlobalSearchDTO globalSearchDTO) 
        {
             
            var obj = await _InvoiceRepository.SearchByAllField(globalSearchDTO);
            var WebResponse = new Response<List<Invoice>>()
            {
                StatusCode = "OK",
                IsSuccess = true,
                Message = "The search was successful",
                Body = obj
            };
            return Ok(WebResponse);
        }
        [HttpPost, Route("Delete")]
        public async Task<ActionResult> Delete([FromBody]int Id) 
        {
            var data = await _InvoiceRepository.Delete(Id);
            var WebResponse = new Response<Invoice>()
            {
                StatusCode = "OK",
                IsSuccess = true,
                Message = "The invoice Was Delete",
                Body = data
            };
            return Ok(WebResponse);
        }
        //check
        [HttpPut, Route("UpdateStatus")]
        public async Task<ActionResult> UpdateStatus(Invoice invoiceDTO)
        {
            Invoice Inv = new Invoice();
            Inv = invoiceDTO;
            Inv.InvoiceId = invoiceDTO.InvoiceId;
            Inv.No_Invoice = invoiceDTO.No_Invoice.Trim().ToUpper();
            Inv.Supplier = invoiceDTO.Supplier.Trim().ToUpper();
            Inv.PaymentDescription = invoiceDTO.PaymentDescription.Trim().ToUpper();
            Inv.Reference = invoiceDTO.Reference.Trim().ToUpper();
            Inv.InvoiceSupplierDate = Convert.ToDateTime(invoiceDTO.InvoiceSupplierDate);
            Inv.ReceptionDate = Convert.ToDateTime(invoiceDTO.ReceptionDate);
            Inv.InvoiceFileRute = invoiceDTO.InvoiceFileRute;
            Inv.status = invoiceDTO.status;
            var data = await _InvoiceRepository.UpdateStatus(Inv);
            return Ok(data);
        }

    
    }  
}
