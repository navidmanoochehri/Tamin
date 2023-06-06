using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    interface IINAssessmentSPEData
    {
        Task DeleteINAssessmentSPE(INAssessmentSPE INAssessmentSPE);
        Task<List<INAssessmentSPE>> GetINAssessmentSPE();
        Task InsertINAssessmentSPE(INAssessmentSPE INAssessmentSPE);
        Task UpdateINAssessmentSPE(INAssessmentSPE INAssessmentSPE);
    }
}