using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentSSData
    {
        Task DeleteINAssessmentSS(INAssessmentSS INAssessmentSS);
        Task<List<INAssessmentSS>> GetINAssessmentSS();
        Task InsertINAssessmentSS(INAssessmentSS INAssessmentSS);
        Task UpdateINAssessmentSS(INAssessmentSS INAssessmentSS);
    }
}