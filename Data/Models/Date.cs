using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Tamin.Data.Models
{
    public class Date
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string CreateDate { get; set; }
        public string Lastlogin { get; set; }
        public string Lastlogout { get; set; }
        public string DeleteDate { get; set; }
    }
}
