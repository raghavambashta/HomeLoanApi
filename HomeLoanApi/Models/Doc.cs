using System;
using System.Collections.Generic;

#nullable disable

namespace HomeLoanApi.Models
{
    public partial class Doc
    {
        public int DId { get; set; }
        public byte[] Aadhaar { get; set; }
        public byte[] Pan { get; set; }
        public byte[] Voter { get; set; }
        public byte[] SalarySlip { get; set; }
        public byte[] Loa { get; set; }
        public byte[] Noc { get; set; }
        public byte[] Agreement { get; set; }
        public int CId { get; set; }

        public virtual Cred CIdNavigation { get; set; }
    }
}
