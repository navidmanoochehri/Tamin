using System.Collections.Generic;
using System.Threading.Tasks;
using Tamin.Data.Models;

namespace Tamin.Data
{
    public interface IDateData
    {
        Task DeleteDate(Date Date);
        Task<List<Date>> GetDate();
        Task InsertDate(Date Date);
        Task UpdateDate(Date Date);
    }
}