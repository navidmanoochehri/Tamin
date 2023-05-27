using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentSCData
    {
        Task DeleteAssessmentSC(AssessmentSC AssessmentSC);
        Task<List<AssessmentSC>> GetAssessmentSC();
        Task InsertAssessmentSC(AssessmentSC AssessmentSC);
        Task UpdateAssessmentSC(AssessmentSC AssessmentSC);
    }
}