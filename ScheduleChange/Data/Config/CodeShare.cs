using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Data
{
    public class MarketingCodeShares
    {
        public int Id { get; set; }
        public string VN_OPS_FlightNumber { get; set; }
        public string MarketingAirline { get; set; }
        public string MarketingFlightNumber { get; set; }
        public int DOW { get; set; }
        public string Segment { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
