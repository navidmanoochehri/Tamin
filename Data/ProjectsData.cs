using Tamin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tamin.Data
{
    public class ProjectsData : IProjectsData
    {
        private readonly ISqlDataAccess _dbProjectsData;

        public ProjectsData(ISqlDataAccess dbProjectsData)
        {
            _dbProjectsData = dbProjectsData;
        }
        public Task<List<Projects>> GetProjects()
        {
            string sql = "SELECT * from dbo.Projects";
            return _dbProjectsData.LoadData<Projects, dynamic>(sql, new { });
        }
        public Task InsertProjects(Projects project)
        {
            string sql = @"INSERT into dbo.Projects (Id, Title) Values (@Id, @Title);";

            return _dbProjectsData.SaveData(sql, project);
        }
        public Task DeleteProjects(ActivityOutPut project)
        {
            string sql = @"DELETE dbo.Projects WHERE Id=@Id";
            return _dbProjectsData.SaveData(sql, project);
        }
        public Task UpdateProjects(ActivityOutPut project)
        {
            string sql = @"UPDATE dbo.Projects set Id=@Id, Title=@Title WHERE Id=@Id";
            return _dbProjectsData.SaveData(sql, project);
        }
    }
}
