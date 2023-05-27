using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentFSData
    {
        Task DeleteINAssessmentFS(INAssessmentFS INAssessmentFS);
        Task<List<INAssessmentFS>> GetINAssessmentFS();
        Task InsertINAssessmentFS(INAssessmentFS INAssessmentFS);
        Task UpdateINAssessmentFS(INAssessmentFS INAssessmentFS);
    }
}