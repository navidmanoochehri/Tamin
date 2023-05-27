using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentFCData : IAssessmentFCData
    {
        private readonly ISqlDataAccess _dbAssessmentFCData;

        public AssessmentFCData(ISqlDataAccess dbAssessmentFCData)
        {
            _dbAssessmentFCData = dbAssessmentFCData;
        }
        public Task<List<AssessmentFC>> GetAssessmentFC()
        {
            string sql = "SELECT * from dbo.AssessmentFC";
            return _dbAssessmentFCData.LoadData<AssessmentFC, dynamic>(sql, new { });
        }
        public Task InsertAssessmentFC(AssessmentFC AssessmentFC)
        {
            string sql = @"INSERT into dbo.AssessmentFC (Id, Vendorlist, Price, Financial,Project , Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Vendorlist, @Price, @Financial, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentFCData.SaveData(sql, AssessmentFC);
        }
        public Task DeleteAssessmentFC(AssessmentFC AssessmentFC)
        {
            string sql = @"DELETE dbo.AssessmentFC WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentFCData.SaveData(sql, AssessmentFC);
        }
        public Task UpdateAssessmentFC(AssessmentFC AssessmentFC)
        {
            string sql = @"UPDATE dbo.AssessmentFC set Id=@Id, Vendorlist=@Vendorlist, Price=@Price, Financial=@Financial,Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentFCData.SaveData(sql, AssessmentFC);
        }
    }

}
