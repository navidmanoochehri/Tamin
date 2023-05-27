using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    public interface IProjectsData
    {
        Task DeleteProjects(ActivityOutPut project);
        Task<List<Projects>> GetProjects();
        Task InsertProjects(Projects project);
        Task UpdateProjects(ActivityOutPut project);
    }
}