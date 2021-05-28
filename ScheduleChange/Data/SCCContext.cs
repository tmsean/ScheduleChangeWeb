using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleChange.Models;

namespace ScheduleChange.Repository
{
    public class SCCContext : DbContext
    {
        public SCCContext(DbContextOptions<SCCContext> options)
            : base(options)
        {

        }
        public DbSet<SCCRequest> SCCRequests { get; set; }
    }
}
