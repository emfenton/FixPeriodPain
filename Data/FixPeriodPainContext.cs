using Microsoft.EntityFrameworkCore;

namespace FixPeriodPain.Data
{
    public class FixPeriodPainContext : DbContext
    {
        public FixPeriodPainContext (
            DbContextOptions<FixPeriodPainContext> options)
            : base(options)
        {
        }

        public DbSet<FixPeriodPain.Models.EmailSignup> EmailSignup { get; set; }
    }
}