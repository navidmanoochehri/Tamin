using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentFPEData : IAssessmentFPEData
    {
        private readonly ISqlDataAccess _dbAssessmentFPEData;

        public AssessmentFPEData(ISqlDataAccess dbAssessmentFPEData)
        {
            _dbAssessmentFPEData = dbAssessmentFPEData;
        }
        public Task<List<AssessmentFPE>> GetAssessmentFPE()
        {
            string sql = "SELECT * from dbo.AssessmentFPE";
            return _dbAssessmentFPEData.LoadData<AssessmentFPE, dynamic>(sql, new { });
        }
        public Task InsertAssessmentFPE(AssessmentFPE AssessmentFPE)
        {
            string sql = @"INSERT into dbo.AssessmentFPE (Id, Vendorlist, Price, Financial,Project , Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Vendorlist, @Price, @Financial, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentFPEData.SaveData(sql, AssessmentFPE);
        }
        public Task DeleteAssessmentFPE(AssessmentFPE AssessmentFPE)
        {
            string sql = @"DELETE dbo.AssessmentFPE WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentFPEData.SaveData(sql, AssessmentFPE);
        }
        public Task UpdateAssessmentFPE(AssessmentFPE AssessmentFPE)
        {
            string sql = @"UPDATE dbo.AssessmentFPE set Id=@Id, Vendorlist=@Vendorlist, Price=@Price, Financial=@Financial,Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentFPEData.SaveData(sql, AssessmentFPE);
        }
    }

}
