using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentFSData : IAssessmentFSData
    {
        private readonly ISqlDataAccess _dbAssessmentFSData;

        public AssessmentFSData(ISqlDataAccess dbAssessmentFSData)
        {
            _dbAssessmentFSData = dbAssessmentFSData;
        }
        public Task<List<AssessmentFS>> GetAssessmentFS()
        {
            string sql = "SELECT * from dbo.AssessmentFS";
            return _dbAssessmentFSData.LoadData<AssessmentFS, dynamic>(sql, new { });
        }
        public Task InsertAssessmentFS(AssessmentFS AssessmentFS)
        {
            string sql = @"INSERT into dbo.AssessmentFS (Id, Price, CustomerOrientation, Financial, Technical, Project, Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Price, @CustomerOrientation, @Financial, @Technical, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentFSData.SaveData(sql, AssessmentFS);
        }
        public Task DeleteAssessmentFS(AssessmentFS AssessmentFS)
        {
            string sql = @"DELETE dbo.AssessmentFS WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentFSData.SaveData(sql, AssessmentFS);
        }
        public Task UpdateAssessmentFS(AssessmentFS AssessmentFS)
        {
            string sql = @"UPDATE dbo.AssessmentFS set Id=@Id, Price=@Price, CustomerOrientation=@CustomerOrientation, Financial=@Financial, Technical=@Technical, Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentFSData.SaveData(sql, AssessmentFS);
        }
    }

}
