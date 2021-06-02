using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models;
using ScheduleChange.Models.Config;

namespace ScheduleChange.Repository
{
    public class SCContext : IdentityDbContext<ApplicationUser>
    {
        public SCContext(DbContextOptions<SCContext> options)
            : base(options)
        {

        }
        public DbSet<SITATEX> SITATEXes { get; set; }
        public DbSet<SubMessage> SubMessages { get; set; }
        public DbSet<SCRequest> SCRequests { get; set; }
        //Tables config
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MarketingCodeShareFlight> MarketingCodeShareFlights { get; set; }
        public DbSet<FlightConfigs> FlightConfigs { get; set; }
        public DbSet<DomesticCity> DomesticCities { get; set; }
        public DbSet<MealsCode> Meals { get; set; }
        public DbSet<PCC> PCCs { get; set; }
        public DbSet<SSCIStation> SSCIStations { get; set; }
        public DbSet<ThreeCompartmentsFlight> ThreeCompartmentsFlights { get; set; }
    }
}
