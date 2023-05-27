using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentSCData
    {
        Task DeleteINAssessmentSC(INAssessmentSC INAssessmentSC);
        Task<List<INAssessmentSC>> GetINAssessmentSC();
        Task InsertINAssessmentSC(INAssessmentSC INAssessmentSC);
        Task UpdateINAssessmentSC(INAssessmentSC INAssessmentSC);
    }
}