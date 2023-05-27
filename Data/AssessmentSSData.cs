using System;
using System.Collections.Generic;
using Tamin.Data.Models;
using System.Threading.Tasks;


namespace Tamin.Data
{
    class AssessmentSSData : IAssessmentSSData
    {
        private readonly ISqlDataAccess _dbAssessmentSSData;

        public AssessmentSSData(ISqlDataAccess dbAssessmentSSData)
        {
            _dbAssessmentSSData = dbAssessmentSSData;
        }
        public Task<List<AssessmentSS>> GetAssessmentSS()
        {
            string sql = "SELECT * from dbo.AssessmentSS";
            return _dbAssessmentSSData.LoadData<AssessmentSS, dynamic>(sql, new { });
        }
        public Task InsertAssessmentSS(AssessmentSS AssessmentSS)
        {
            string sql = @"INSERT into dbo.AssessmentSS (Id, Quality, Price, Delivery, CustomerOrientation, Financial, Technical, HSE_QC, Project, Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Quality, @Price, @Delivery, @CustomerOrientation, @Financial, @Technical, @HSE_QC, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentSSData.SaveData(sql, AssessmentSS);
        }
        public Task DeleteAssessmentSS(AssessmentSS AssessmentSS)
        {
            string sql = @"DELETE dbo.AssessmentSS WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentSSData.SaveData(sql, AssessmentSS);
        }
        public Task UpdateAssessmentSS(AssessmentSS AssessmentSS)
        {
            string sql = @"UPDATE dbo.AssessmentSS set Id=@Id, Quality=@Quality, Price=@Price, Delivery=@Delivery, CustomerOrientation=@CustomerOrientation, Financial=@Financial, Technical=@Technical, HSE_QC=@HSE_QC, Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentSSData.SaveData(sql, AssessmentSS);
        }
    }

}
