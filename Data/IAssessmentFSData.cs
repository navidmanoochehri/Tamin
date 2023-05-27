using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentFSData
    {
        Task DeleteAssessmentFS(AssessmentFS AssessmentFS);
        Task<List<AssessmentFS>> GetAssessmentFS();
        Task InsertAssessmentFS(AssessmentFS AssessmentFS);
        Task UpdateAssessmentFS(AssessmentFS AssessmentFS);
    }
}