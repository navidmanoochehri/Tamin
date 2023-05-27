using System.ComponentModel.DataAnnotations;

namespace Tamin.Data.Models
{
    public class ActivityOutPut
    {

        [key]
        public int Id { get; set; }
        public string Title { get; set; }

        
               
    }
}
