using AutoMapper;
using LogisticsCenterAPI.Data;
using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.ExternalUserRepository
{
    public class ExternalUserRepository : IExternalUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public ExternalUserRepository(ApplicationDbContext applicationDbContext, IMapper mapper) 
        {
            _dbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<External_User> Create(External_UserDTO external_User)
        {
            var obj = _mapper.Map<External_User>(external_User);
            var data = await _dbContext.External_User.AddAsync(obj);
            await _dbContext.SaveChangesAsync();
            return obj;
        }

        public async Task<List<External_User>> Get()
        {
            return await Task.FromResult(_dbContext.External_User.ToList());
        }

        public async  Task<External_User> Update(External_UserDTO external_User)
        {
            var obj = _mapper.Map<External_User>(external_User);
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return obj;
        }
    }
}
