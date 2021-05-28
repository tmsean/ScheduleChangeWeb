using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data;
using ScheduleChange.Data.Config;

namespace ScheduleChange.Repository
{
    public class SCCContext : DbContext
    {
        public SCCContext(DbContextOptions<SCCContext> options)
            : base(options)
        {

        }
        public DbSet<SCCRequest> SCCRequests { get; set; }

        //Tables config
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<MarketingCodeShareFlights> MarketingCodeShareFlights { get; set; }
        public DbSet<FlightConfig> Configs { get; set; }
        public DbSet<DomesticCities> DomesticCities { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<PCC> PCCs { get; set; }
        public DbSet<SSCIStation> SSCIStations { get; set; }
        public DbSet<ThreeCompartmentsFlight> ThreeCompartmentsFlights { get; set; }

    }
}
