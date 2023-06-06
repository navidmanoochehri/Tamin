using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentFPEData
    {
        Task DeleteAssessmentFPE(AssessmentFPE AssessmentFPE);
        Task<List<AssessmentFPE>> GetAssessmentFPE();
        Task InsertAssessmentFPE(AssessmentFPE AssessmentFPE);
        Task UpdateAssessmentFPE(AssessmentFPE AssessmentFPE);
    }
}