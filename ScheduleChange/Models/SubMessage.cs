using System.ComponentModel.DataAnnotations;

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
