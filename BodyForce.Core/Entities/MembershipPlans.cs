using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class MembershipPlans
    {
        [Key]
        public int PlanId { get; set; }
        public string? PlanName { get; set; }
        public int DurationInMonths { get; set; }
        public double FeeAmount { get; set; }
        public string? Description { get; set; }
    }
}
