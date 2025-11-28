using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyForceAPI
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string? Type { get; set; }
        public string? Message { get; set; }
        public DateTime? SentDate { get; set; }
    }
}
