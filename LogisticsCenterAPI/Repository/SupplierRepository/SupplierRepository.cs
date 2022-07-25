using AutoMapper;
using LogisticsCenterAPI.Data;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LogisticsCenterAPI.Repository.SupplierRepository
{
    public class SupplierRepository : ISupplierRepository
    {
        private IMapper _mapper;
        private readonly ApplicationDbContext _dbContext;
        public SupplierRepository(ApplicationDbContext applicationDbContext, IMapper mapper) 
        {
            this._dbContext = applicationDbContext;
            this._mapper = mapper;
        }
        public async Task<Supplier> Create(SupplierDTO supplier)
        {
            var obj = _mapper.Map<Supplier>(supplier);
            var data = await _dbContext.Supplier.AddAsync(obj);
            await _dbContext.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<List<Supplier>> Get()
        {
            var data = await Task.FromResult(_dbContext.Supplier.ToList());
            return data;
        }

        public async Task<Supplier> Update(SupplierDTO supplier)
        {
            try
            {
                var obj = _mapper.Map<Supplier>(supplier);
                //var oldSupplier = _dbContext.Supplier.FirstOrDefault(x => x.Id == supplier.Id);
                //_dbContext.Entry(oldSupplier).State = EntityState.Detached;

                var data =  _dbContext.Entry(obj).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return obj;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}