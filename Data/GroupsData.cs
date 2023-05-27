using Tamin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tamin.Data
{
    class GroupsData : IGroupsData
    {
        private readonly ISqlDataAccess _dbGroupsData;

        public GroupsData(ISqlDataAccess dbGroupsData)
        {
            _dbGroupsData = dbGroupsData;
        }
        public Task<List<Groups>> GetGroup()
        {
            string sql = "SELECT * from dbo.Groups";
            return _dbGroupsData.LoadData<Groups, dynamic>(sql, new { });
        }
        public Task InsertGroups(Groups group)
        {
            string sql = @"INSERT into dbo.Groups (Id, Title) Values (@Id, @Title);";

            return _dbGroupsData.SaveData(sql, group);
        }
        public Task DeleteGroups(Groups group)
        {
            string sql = @"DELETE dbo.Groups WHERE Id=@Id";
            return _dbGroupsData.SaveData(sql, group);
        }
        public Task UpdateGroups(Groups group)
        {
            string sql = @"UPDATE dbo.Groups set Id=@Id, Title=@Title WHERE Id=@Id";
            return _dbGroupsData.SaveData(sql, group);
        }
    }
}
