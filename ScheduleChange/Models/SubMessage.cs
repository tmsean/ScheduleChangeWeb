using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Models
{
    public class SubMessage
    {
        public int ID { get; set; }
        public string MessageID { get; set; }
        [Required]
        public string Content { get; set; }
        public int SITATEXID { get; set; }
    }
}
