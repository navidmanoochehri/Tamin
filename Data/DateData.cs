using Tamin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tamin.Data
{
    public class DateData : IDateData
    {
        private readonly ISqlDataAccess _dbDateData;

        public DateData(ISqlDataAccess dbDateData)
        {
            _dbDateData = dbDateData;
        }
        public Task<List<Date>> GetDate()
        {
            string sql = "SELECT * from dbo.Date";
            return _dbDateData.LoadData<Date, dynamic>(sql, new { });
        }
        public Task InsertDate(Date Date)
        {
            string sql = @"INSERT into dbo.Date (Id, UserName , CreateDate, Lastlogin, Lastlogout, DeleteDate) Values (@Id, @UserName , @CreateDate, @Lastlogin, @Lastlogout, @DeleteDate);";

            return _dbDateData.SaveData(sql, Date);
        }
        public Task DeleteDate(Date Date)
        {
            string sql = @"DELETE dbo.Date WHERE Id=@Id";
            return _dbDateData.SaveData(sql, Date);
        }
        public Task UpdateDate(Date Date)
        {
            string sql = @"UPDATE dbo.Date set Id=@Id, UserName=@UserName , CreateDate=@CreateDate, Lastlogin=@Lastlogin, Lastlogout=@Lastlogout, DeleteDate=@DeleteDate WHERE Id=@Id";
            return _dbDateData.SaveData(sql, Date);
        }
    }
}
