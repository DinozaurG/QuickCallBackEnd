using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickCallBackEnd.Models
{
    public class Contact
    {
        public Int32 Id { get; set; }

        public Int32 UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string PhoneNumber { get; set; }

        public string ImageFilePath { get; set; }
    }
}
