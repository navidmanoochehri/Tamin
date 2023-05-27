using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tamin.Data.Models
{
    public class INAssessmentSC
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public int IdGroup { get; set; }

    }
}
