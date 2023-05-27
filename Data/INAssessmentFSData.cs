using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class INAssessmentFSData : IINAssessmentFSData
    {
        private readonly ISqlDataAccess _dbINAssessmentFS;

        public INAssessmentFSData(ISqlDataAccess dbINAssessmentFS)
        {
            _dbINAssessmentFS = dbINAssessmentFS;
        }
        public Task<List<INAssessmentFS>> GetINAssessmentFS()
        {
            string sql = "SELECT * from dbo.INAssessmentFS";
            return _dbINAssessmentFS.LoadData<INAssessmentFS, dynamic>(sql, new { });
        }
        public Task InsertINAssessmentFS(INAssessmentFS INAssessmentFS)
        {
            string sql = @"INSERT into dbo.INAssessmentFS (Id, Title, Score, IdGroup) Values (@Id, @Title, @Score, @IdGroup);";

            return _dbINAssessmentFS.SaveData(sql, INAssessmentFS);
        }
        public Task DeleteINAssessmentFS(INAssessmentFS INAssessmentFS)
        {
            string sql = @"DELETE dbo.INAssessmentFS WHERE Id=@Id";
            return _dbINAssessmentFS.SaveData(sql, INAssessmentFS);
        }
        public Task UpdateINAssessmentFS(INAssessmentFS INAssessmentFS)
        {
            string sql = @"UPDATE dbo.INAssessmentFS set Id=@Id, Title=@Title, Score=@Score, IdGroup=@IdGroup WHERE Id=@Id";
            return _dbINAssessmentFS.SaveData(sql, INAssessmentFS);
        }
    }

}
