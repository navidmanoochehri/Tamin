using Tamin.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tamin.Data
{
    public interface IVendorData
    {
        Task DeleteVendores(VendorInPut vendor);
        Task<List<VendorInPut>> GetVendors();
        Task InsertVendors(VendorInPut vendor);
        Task UpdateVendors(VendorInPut vendor);
     
    }
}