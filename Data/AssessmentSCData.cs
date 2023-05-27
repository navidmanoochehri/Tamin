using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentSCData : IAssessmentSCData
    {
        private readonly ISqlDataAccess _dbAssessmentSCData;

        public AssessmentSCData(ISqlDataAccess dbAssessmentSCData)
        {
            _dbAssessmentSCData = dbAssessmentSCData;
        }
        public Task<List<AssessmentSC>> GetAssessmentSC()
        {
            string sql = "SELECT * from dbo.AssessmentSC";
            return _dbAssessmentSCData.LoadData<AssessmentSC, dynamic>(sql, new { });
        }
        public Task InsertAssessmentSC(AssessmentSC AssessmentSC)
        {
            string sql = @"INSERT into dbo.AssessmentSC (Id, Quality, Vendorlist, Price, Delivery, CustomerOrientation, Financial, Project, Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Quality, @Vendorlist, @Price, @Delivery, @CustomerOrientation, @Financial, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentSCData.SaveData(sql, AssessmentSC);
        }
        public Task DeleteAssessmentSC(AssessmentSC AssessmentSC)
        {
            string sql = @"DELETE dbo.AssessmentSC WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentSCData.SaveData(sql, AssessmentSC);
        }
        public Task UpdateAssessmentSC(AssessmentSC AssessmentSC)
        {
            string sql = @"UPDATE dbo.AssessmentSC set Id=@Id, Vendorlist=@Vendorlist, Price=@Price, Delivery=@Delivery, CustomerOrientation=@CustomerOrientation, Financial=@Financial, Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Quality=@Quality, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentSCData.SaveData(sql, AssessmentSC);
        }
    }

}
