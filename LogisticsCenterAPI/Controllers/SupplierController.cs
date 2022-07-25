using LogisticsCenterAPI.Repository.SupplierRepository;
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
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierController(ISupplierRepository supplier) 
        {
            this._supplierRepository = supplier;
        }

        [HttpGet, Route("Get")]
        public async Task<ActionResult<Supplier>> Get() 
        {
            var data =  await _supplierRepository.Get();
            var webResponse = new Response<List<Supplier>>();

            webResponse = new Response<List<Supplier>>()
            {
                IsSuccess = true,
                Message = "The list was returned",
                StatusCode = "OK",
                Body = data
            };
            return Ok(webResponse);
        }
        
        [HttpPost, Route("Create")]
        public async Task<ActionResult<Supplier>> Create( SupplierDTO supplierDTO)
        {
            var data = await _supplierRepository.Create(supplierDTO);
            return Ok(data);
        }

        [HttpPost, Route("Update")]
        public async Task<ActionResult<Supplier>> Update(SupplierDTO supplierDTO)
        {
            var supplier = await _supplierRepository.Update(supplierDTO);
            return Ok(supplier);
        }
       


    }
}
