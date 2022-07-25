using LogisticsCenterMODELS.Models;
using LogisticsCenterMODELS.Models.DTOModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogisticsCenterAPI.Repository.SupplierRepository
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> Get();
        Task<Supplier> Update(SupplierDTO supplier);  
        Task<Supplier> Create(SupplierDTO supplier);
    }
}
