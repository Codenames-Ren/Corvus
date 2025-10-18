using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.Models
{
    public class Balance
    {
        public int Id { get; set; } 
        public String MemberCode { get; set; }
        public decimal amount { get; set; }
        public DateTime updateOn { get; set; }
        public string transactionName    { get; set; }
        public string flow { get; set; }

    }
}
