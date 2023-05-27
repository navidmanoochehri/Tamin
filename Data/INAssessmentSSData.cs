using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentSSData : IINAssessmentSSData
    {
        private readonly ISqlDataAccess _dbINAssessmentSS;

        public INAssessmentSSData(ISqlDataAccess dbINAssessmentSS)
        {
            _dbINAssessmentSS = dbINAssessmentSS;
        }
        public Task<List<INAssessmentSS>> GetINAssessmentSS()
        {
            string sql = "SELECT * from dbo.INAssessmentSS";
            return _dbINAssessmentSS.LoadData<INAssessmentSS, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentSS(INAssessmentSS INAssessmentSS)
        {
            string sql = @"INSERT into dbo.INAssessmentSS (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentSS.SaveData(sql, INAssessmentSS);
        }
        public Task DeleteINAssessmentSS(INAssessmentSS INAssessmentSS)
        {
            string sql = @"DELETE dbo.INAssessmentSS WHERE Id=@Id";
            return _dbINAssessmentSS.SaveData(sql, INAssessmentSS);
        }
        public Task UpdateINAssessmentSS(INAssessmentSS INAssessmentSS)
        {
            string sql = @"UPDATE dbo.INAssessmentSS set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentSS.SaveData(sql, INAssessmentSS);
        }
    }

}
