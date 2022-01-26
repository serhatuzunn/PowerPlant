using Microsoft.EntityFrameworkCore;
using PowertPlant.WebApi.Entity;

namespace PowertPlant.WebApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ElectroMeter> ElectroMeters { get; set; }
        public DbSet<TimedValue> TimedValues { get; set; }
    }
}
