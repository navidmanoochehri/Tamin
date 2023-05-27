using Tamin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tamin.Data
{
    class ActivityData : IActivityData
    {
        private readonly ISqlDataAccess _dbActivityData;

        public ActivityData(ISqlDataAccess dbActivityData)
        {
            _dbActivityData = dbActivityData;
        }
        public Task<List<ActivityOutPut>> GetActivity()
        {
            string sql = "SELECT * from dbo.Activity";
            return _dbActivityData.LoadData<ActivityOutPut, dynamic>(sql, new { });
        }
        public Task InsertActivity(ActivityOutPut activity)
        {
            string sql = @"INSERT into dbo.Activity (Id, Title) Values (@Id, @Title);";

            return _dbActivityData.SaveData(sql, activity);
        }
        public Task DeleteActivity(ActivityOutPut activity)
        {
            string sql = @"DELETE dbo.Activity WHERE Id=@Id";
            return _dbActivityData.SaveData(sql, activity);
        }
        public Task UpdateActivity(ActivityOutPut activity)
        {
            string sql = @"UPDATE dbo.Activity set Id=@Id, Title=@Title WHERE Id=@Id";
            return _dbActivityData.SaveData(sql, activity);
        }
    }
}