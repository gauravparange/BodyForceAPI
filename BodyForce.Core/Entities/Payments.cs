using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        public int MembershipId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double AmountPaid { get; set; }
        public string? PaymentMode { get; set; }
            
    }
}
