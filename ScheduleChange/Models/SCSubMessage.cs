using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Models
{
    public class SCSubMessage
    {
        public int ID { get; set; }
        public string MessageID { get; set; }
        public string Content { get; set; }
        public int SC_SITATEXID { get; set; }
    }
}
