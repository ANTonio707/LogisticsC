using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.ExternalUserRepository
{
    public interface IExternalUserRepository
    {
        Task<List<External_User>> Get();
        Task<External_User> Create(External_UserDTO external_Users);

        Task<External_User> Update(External_UserDTO external_Users);
    }
}
