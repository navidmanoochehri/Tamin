using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentSCData : IINAssessmentSCData
    {
        private readonly ISqlDataAccess _dbINAssessmentSC;

        public INAssessmentSCData(ISqlDataAccess dbINAssessmentSC)
        {
            _dbINAssessmentSC = dbINAssessmentSC;
        }
        public Task<List<INAssessmentSC>> GetINAssessmentSC()
        {
            string sql = "SELECT * from dbo.INAssessmentSC";
            return _dbINAssessmentSC.LoadData<INAssessmentSC, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentSC(INAssessmentSC INAssessmentSC)
        {
            string sql = @"INSERT into dbo.INAssessmentSC (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentSC.SaveData(sql, INAssessmentSC);
        }
        public Task DeleteINAssessmentSC(INAssessmentSC INAssessmentSC)
        {
            string sql = @"DELETE dbo.INAssessmentSC WHERE Id=@Id";
            return _dbINAssessmentSC.SaveData(sql, INAssessmentSC);
        }
        public Task UpdateINAssessmentSC(INAssessmentSC INAssessmentSC)
        {
            string sql = @"UPDATE dbo.INAssessmentSC set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentSC.SaveData(sql, INAssessmentSC);
        }
    }

}
