using System.ComponentModel.DataAnnotations;

namespace Tamin.Data.Models
{
    public class INAssessmentFC
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public int IdGroup { get; set; }
    }
}
