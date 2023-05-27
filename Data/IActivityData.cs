using Tamin.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tamin.Data
{
    interface IActivityData
    {
        Task<List<ActivityOutPut>> GetActivity();
        Task InsertActivity(ActivityOutPut activity);
        Task UpdateActivity(ActivityOutPut activity);
        Task DeleteActivity(ActivityOutPut activity);
    }
}