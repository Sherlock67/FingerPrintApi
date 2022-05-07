using FingerprintAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FingerprintAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {




        }
        public DbSet<FingerPrint> fingerprints { get; set; } 


    }
}
