using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tamin.Data.Models
{
    public class VendorInPut
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "نام باید بین ۲ تا ۶۰ کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا نام شرکت را کامل وارد کنید")]
        [Display(Name = "نام شرکت")]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "نام باید بین ۲ تا ۶۰ کاراکتر باشد")]
        //[Required(ErrorMessage = "لطفا نام مدیر عامل را وارد کنید")]
        [Display(Name = "نام مدیر عامل ")]
        public string ManagerName { get; set; }

        [Phone(ErrorMessage = "لطفا شماره تلفن را درست وارد کنید")]
        [Required(ErrorMessage = "لطفا شماره تماس را وارد کنید")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "شماره تماس حداقل ۴ رقم است")]
        [Display(Name = "شماره تماس")]
        public string Phone { get; set; }

        [StringLength(500, MinimumLength = 2, ErrorMessage = "طول آدرس بین ۲ تا ۵۰۰ کاراکتر است")]
        [Required(ErrorMessage = "لطفا نشانی دفترمرکزی را وارد کنید")]
        [Display(Name = "نشانی دفترمرکزی")]
        public string Address { get; set; }

        [Phone(ErrorMessage = "لطفا شماره فکس را درست وارد کنید")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "شماره فکس حداقل ۴ رقم است")]
        [Display(Name = "شماره فکس")]
        //[Required(ErrorMessage = "لطفا شماره فکس را وارد کنید")]
        public string Fax { get; set; }

        [StringLength(500)]
        [Display(Name = "صندق پستی")]
        public string MailBox { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "رایانامه")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "رایانامه باید بین ۵ تا ۲۵۰ کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا رایانامه را وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفا رایانامه را درست وارد کنید")]
        public string EMail { get; set; }

        [Display(Name = "فاقد شماره ثبت ")]
        public bool CheckRegistrationNo { get; set; }

        [RegularExpression(@"\d{1,6}", ErrorMessage = "شماره ثبت حداکثر ۶ رقم میباشد")]
        [Display(Name = "شماره ثبت")]
        public string RegistrationNo { get; set; }

        [Display(Name = "فاقد شماره اقتصادی")]
        public bool CheckEconomicCode { get; set; }

        [RegularExpression(@"\d{12}", ErrorMessage = "شماره اقتصادی ۱۲ رقم می باشد")]
        [Display(Name = "شماره اقتصادی")]
        public string EconomicCode { get; set; }

        [RegularExpression(@"\d{10}", ErrorMessage = "کد پستی ۱۰ رقم می باشد")]
        [Display(Name = "کد پستی")]

        public string PostalCode { get; set; }

        [RegularExpression(@"(www.|[a-zA-Z0-9].)[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,6}(\:[0-9]{1,5})*(/($|[a-zA-Z0-9\.\,\;\?\'\\\+&amp;%\$#\=~_\-]+))*$", ErrorMessage = "آدرس سایت را درست وارد کنید.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "آدرس سایت حداقل ۴ کاراکتر میباشد")]
        [Display(Name = "وب سایت")]
        public string WebSite { get; set; }


        [Display(Name = "فاقد شناسه ملی")]
        public bool CheckNatioalId { get; set; }

        [RegularExpression(@"\d{12}", ErrorMessage = "شناسه ملی ۱2 رقم می باشد")]
        [Display(Name = "شناسه ملی")]
        public string NatioalId { get; set; }

        public string Catalog { get; set; }


        [Display(Name = "آیا تا کنون سابقه همکاری با شرکت تناوب داشته اید؟ ")]
        public bool HasCooperationResume { get; set; }

        [Display(Name = "شرح دهید ")]
        [DataType(DataType.MultilineText)]
        public string CooperationResume { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "عضو وندور لیست خاصی هستید؟ نام  ببرید")]
        public string VendorListResume { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "شرح فعالیت ")]
        public string ActivityDescription { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "زمینه (های) اصلی فعالیت ")]
        [Required(ErrorMessage = "زمینه (های) اصلی فعالیت را وارد کنید")]
        public string Activities { get; set; }
        public string Date { get; set; }
        [Required(ErrorMessage = "گروه کاری را وارد کنید")]
        public string Groups { get; set; }
        public string Projects { get; set; }
        public string Status { get; set; }
        public string EditDate { get; set; }
    }
}

