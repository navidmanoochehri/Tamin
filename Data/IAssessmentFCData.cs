using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentFCData
    {
        Task DeleteAssessmentFC(AssessmentFC AssessmentFC);
        Task<List<AssessmentFC>> GetAssessmentFC();
        Task InsertAssessmentFC(AssessmentFC AssessmentFC);
        Task UpdateAssessmentFC(AssessmentFC AssessmentFC);
    }
}