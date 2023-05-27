using System.ComponentModel.DataAnnotations;

namespace Tamin.Data.Models
{
    public class Groups
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
