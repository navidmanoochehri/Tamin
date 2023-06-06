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
            string sql = @"INSERT into dbo.AssessmentSPE (Id, Timing, Quality, Standard, Equipment_protection, Material_protection, Protection_consumables, Resource_management, Technical_ability,Professionalism, Status_face, Correct_use, Material_balance, Project, Sum, Grade, Date, MDate, Comment, Image) Values (@Id, @Timing, @Quality, @Standard, @Equipment_protection, @Material_protection, @Protection_consumables, @Resource_management, @Technical_ability, @Professionalism, @Status_face, @Correct_use, @Material_balance, @Project, @Sum, @Grade, @Date, @MDate, @Comment, @Image);";

            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
        public Task DeleteAssessmentSPE(AssessmentSPE AssessmentSPE)
        {
            string sql = @"DELETE dbo.AssessmentSPE WHERE (Id=@Id AND Date=@Date AND Project=@Project)";
            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
        public Task UpdateAssessmentSPE(AssessmentSPE AssessmentSPE)
        {
            string sql = @"UPDATE dbo.AssessmentSPE set Id=@Id, Timing=@Timing, Quality=@Quality, Standard=@Standard, Equipment_protection=@Equipment_protection, Material_protection=@Material_protection, Protection_consumables=@Protection_consumables, Resource_management=@Resource_management, Technical_ability=@Technical_ability, Professionalism=@Professionalism, Status_face=@Status_face, Correct_use=@Correct_use, Material_balance=@Material_balance, Project=@Project, Sum=@Sum, Grade=@Grade, Date=@Date, MDate=@MDate, Comment=@Comment, Quality=@Quality, Image=@Image WHERE (Id=@Id AND Date=@Date)";
            return _dbAssessmentSPEData.SaveData(sql, AssessmentSPE);
        }
    }

}
