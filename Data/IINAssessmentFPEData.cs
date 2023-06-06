using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentFPEData
    {
        Task DeleteINAssessmentFPE(INAssessmentFPE INAssessmentFPE);
        Task<List<INAssessmentFPE>> GetINAssessmentFPE();
        Task InsertINAssessmentFPE(INAssessmentFPE INAssessmentFPE);
        Task UpdateINAssessmentFPE(INAssessmentFPE INAssessmentFPE);
    }
}