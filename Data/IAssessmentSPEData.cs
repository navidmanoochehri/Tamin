using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentSPEData
    {
        Task DeleteAssessmentSPE(AssessmentSPE AssessmentSPE);
        Task<List<AssessmentSPE>> GetAssessmentSPE();
        Task InsertAssessmentSPE(AssessmentSPE AssessmentSPE);
        Task UpdateAssessmentSPE(AssessmentSPE AssessmentSPE);
    }
}