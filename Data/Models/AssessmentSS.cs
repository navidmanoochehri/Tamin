using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Drawing;

namespace Tamin.Data.Models
{
    public class AssessmentSS
    {
        public int Id { get; set; }
        public int Quality { get; set; }
        public int Price { get; set; }
        public int Delivery { get; set; }
        public int CustomerOrientation { get; set; }
        public int Financial { get; set; }
        public int Technical { get; set; }
        public int HSE_QC { get; set; }
        public string Project { get; set; }
        public int Sum { get; set; }
        public string Grade { get; set; }
        public string Date { get; set; }
        public string MDate { get; set; }
        public string Comment { get; set; }
        public byte[] Image { get; set; }

    }
}
