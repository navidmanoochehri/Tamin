using Tamin.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tamin.Data
{
    interface IGroupsData
    {
        Task<List<Groups>> GetGroup();
        Task InsertGroups(Groups group);
        Task UpdateGroups(Groups group);
        Task DeleteGroups(Groups group);
    }
}