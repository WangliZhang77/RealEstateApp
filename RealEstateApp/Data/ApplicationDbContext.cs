using Microsoft.EntityFrameworkCore;
using RealEstateApp.Models;



namespace RealEstateApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
            ): base (options)
        {

        }
        public DbSet<ListingCase> ListingCases { get; set; }
        public DbSet<Agent>Agents { get; set; } 

        public DbSet<CaseContact>caseContacts { get; set; } 
    }
}
