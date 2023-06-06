using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentSPEData : IINAssessmentSPEData
    {
        private readonly ISqlDataAccess _dbINAssessmentSPE;

        public INAssessmentSPEData(ISqlDataAccess dbINAssessmentSPE)
        {
            _dbINAssessmentSPE = dbINAssessmentSPE;
        }
        public Task<List<INAssessmentSPE>> GetINAssessmentSPE()
        {
            string sql = "SELECT * from dbo.INAssessmentSPE";
            return _dbINAssessmentSPE.LoadData<INAssessmentSPE, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentSPE(INAssessmentSPE INAssessmentSPE)
        {
            string sql = @"INSERT into dbo.INAssessmentSPE (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentSPE.SaveData(sql, INAssessmentSPE);
        }
        public Task DeleteINAssessmentSPE(INAssessmentSPE INAssessmentSPE)
        {
            string sql = @"DELETE dbo.INAssessmentSPE WHERE Id=@Id";
            return _dbINAssessmentSPE.SaveData(sql, INAssessmentSPE);
        }
        public Task UpdateINAssessmentSPE(INAssessmentSPE INAssessmentSPE)
        {
            string sql = @"UPDATE dbo.INAssessmentSPE set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentSPE.SaveData(sql, INAssessmentSPE);
        }
    }

}
