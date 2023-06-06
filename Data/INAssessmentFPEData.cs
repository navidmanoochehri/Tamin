using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentFPEData : IINAssessmentFPEData
    {
        private readonly ISqlDataAccess _dbINAssessmentFPE;

        public INAssessmentFPEData(ISqlDataAccess dbINAssessmentFPE)
        {
            _dbINAssessmentFPE = dbINAssessmentFPE;
        }
        public Task<List<INAssessmentFPE>> GetINAssessmentFPE()
        {
            string sql = "SELECT * from dbo.INAssessmentFPE";
            return _dbINAssessmentFPE.LoadData<INAssessmentFPE, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentFPE(INAssessmentFPE INAssessmentFPE)
        {
            string sql = @"INSERT into dbo.INAssessmentFPE (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentFPE.SaveData(sql, INAssessmentFPE);
        }
        public Task DeleteINAssessmentFPE(INAssessmentFPE INAssessmentFPE)
        {
            string sql = @"DELETE dbo.INAssessmentFPE WHERE Id=@Id";
            return _dbINAssessmentFPE.SaveData(sql, INAssessmentFPE);
        }
        public Task UpdateINAssessmentFPE(INAssessmentFPE INAssessmentFPE)
        {
            string sql = @"UPDATE dbo.INAssessmentFPE set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentFPE.SaveData(sql, INAssessmentFPE);
        }
    }

}
