using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF.Models
{
    public class Contact: BaseEntity
    {
        public string FullName { get; set; }
        public string WorkPhoneNo { get; set; }
        public string MobileNo { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
