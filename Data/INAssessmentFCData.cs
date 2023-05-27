using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentFCData : IINAssessmentFCData
    {
        private readonly ISqlDataAccess _dbINAssessmentFC;

        public INAssessmentFCData(ISqlDataAccess dbINAssessmentFC)
        {
            _dbINAssessmentFC = dbINAssessmentFC;
        }
        public Task<List<INAssessmentFC>> GetINAssessmentFC()
        {
            string sql = "SELECT * from dbo.INAssessmentFC";
            return _dbINAssessmentFC.LoadData<INAssessmentFC, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentFC(INAssessmentFC INAssessmentFC)
        {
            string sql = @"INSERT into dbo.INAssessmentFC (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentFC.SaveData(sql, INAssessmentFC);
        }
        public Task DeleteINAssessmentFC(INAssessmentFC INAssessmentFC)
        {
            string sql = @"DELETE dbo.INAssessmentFC WHERE Id=@Id";
            return _dbINAssessmentFC.SaveData(sql, INAssessmentFC);
        }
        public Task UpdateINAssessmentFC(INAssessmentFC INAssessmentFC)
        {
            string sql = @"UPDATE dbo.INAssessmentFC set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentFC.SaveData(sql, INAssessmentFC);
        }
    }

}
