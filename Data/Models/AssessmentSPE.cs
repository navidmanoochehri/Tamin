using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Drawing;

namespace Tamin.Data.Models
{
    public class AssessmentSPE
    {
        public int Id { get; set; }
        public int Timing { get; set; }
        public int Quality { get; set; }
        public int Standard { get; set; }
        public int Equipment_protection { get; set; }
        public int Material_protection { get; set; }
        public int Protection_consumables { get; set; }
        public int Resource_management { get; set; }
        public int Technical_ability { get; set; }
        public int Professionalism { get; set; }
        public int Status_face { get; set; }
        public int Correct_use { get; set; }
        public int Material_balance { get; set; }
        public string Project { get; set; }
        public int Sum { get; set; }
        public string Grade { get; set; }
        public string Date { get; set; }
        public string MDate { get; set; }
        public string Comment { get; set; }
        public byte[] Image { get; set; }


    }
}
