using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IAssessmentSSData
    {
        Task DeleteAssessmentSS(AssessmentSS AssessmentSS);
        Task<List<AssessmentSS>> GetAssessmentSS();
        Task InsertAssessmentSS(AssessmentSS AssessmentSS);
        Task UpdateAssessmentSS(AssessmentSS AssessmentSS);
    }
}