using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentSPEData : IAssessmentSPEData
    {
        private readonly ISqlDataAccess _dbAssessmentSPEData;

        public AssessmentSPEData(ISqlDataAccess dbAssessmentSPEData)
        {
            _dbAssessmentSPEData = dbAssessmentSPEData;
        }
        public Task<List<AssessmentSPE>> GetAssessmentSPE()
        {
            string sql = "SELECT * from dbo.AssessmentSPE";
            return _dbAssessmentSPEData.LoadData<AssessmentSPE, dynamic>(sql, new { });
        }
        public Task InsertAssessmentSPE(AssessmentSPE AssessmentSPE)
        {
            string sql = @"INSERT into dbo.AssessmentSPE (Id, Quality, Vendorlist, Price, Delivery, CustomerOrientation, Financial, Project, Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Quality, @Vendorlist, @Price, @Delivery, @CustomerOrientation, @Financial, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
        public Task DeleteAssessmentSPE(AssessmentSPE AssessmentSPE)
        {
            string sql = @"DELETE dbo.AssessmentSPE WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
        public Task UpdateAssessmentSPE(AssessmentSPE AssessmentSPE)
        {
            string sql = @"UPDATE dbo.AssessmentSPE set Id=@Id, Vendorlist=@Vendorlist, Price=@Price, Delivery=@Delivery, CustomerOrientation=@CustomerOrientation, Financial=@Financial, Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Quality=@Quality, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
    }

}
