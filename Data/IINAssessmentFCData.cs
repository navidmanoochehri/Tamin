using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentFCData
    {
        Task DeleteINAssessmentFC(INAssessmentFC INAssessmentFC);
        Task<List<INAssessmentFC>> GetINAssessmentFC();
        Task InsertINAssessmentFC(INAssessmentFC INAssessmentFC);
        Task UpdateINAssessmentFC(INAssessmentFC INAssessmentFC);
    }
}