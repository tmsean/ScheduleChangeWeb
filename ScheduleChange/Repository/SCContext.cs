using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data;
using ScheduleChange.Models.Config;

namespace ScheduleChange.Repository
{
    public class SCContext : DbContext
    {
        public SCContext(DbContextOptions<SCContext> options)
            : base(options)
        {

        }
        public DbSet<SCRequest> SCCRequests { get; set; }

        //Tables config
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MarketingCodeShareFlight> MarketingCodeShareFlights { get; set; }
        public DbSet<FlightConfigs> Configs { get; set; }
        public DbSet<DomesticCity> DomesticCities { get; set; }
        public DbSet<MealsCode> Meals { get; set; }
        public DbSet<PCC> PCCs { get; set; }
        public DbSet<SSCIStation> SSCIStations { get; set; }
        public DbSet<ThreeCompartmentsFlight> ThreeCompartmentsFlights { get; set; }

    }
}
