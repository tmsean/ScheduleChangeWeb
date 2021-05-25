using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Data
{
    public class ThreeCompartmentsFlight
    {
        public string FlightNumber { get; set; }
        public DateTime DepDateFrom { get; set; }
        public DateTime DepDateTo { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
