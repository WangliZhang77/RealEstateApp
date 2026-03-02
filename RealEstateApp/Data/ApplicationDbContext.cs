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
        public DbSet<UserIdentityUser> UserIdentityUsers { get; set; }
        public DbSet<PhotographyCompany> PhotographyCompanies { get; set; }
        public DbSet<MediaAsset> MediaAssets { get; set; }
        public DbSet<AgentListingCase> AgentListingCases { get; set; }
        public DbSet<AgentPhotographyCompany> AgentPhotographyCompanies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<AgentListingCase>()
                .HasKey(alc => new { alc.AgentId, alc.ListingCaseId });

            modelBuilder.Entity<AgentListingCase>()
                .HasOne(alc => alc.Agent)
                .WithMany()
                .HasForeignKey(alc => alc.AgentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AgentListingCase>()
                .HasOne(alc => alc.ListingCase)
                .WithMany()
                .HasForeignKey(alc => alc.ListingCaseId)
                .OnDelete(DeleteBehavior.Cascade);

           
            modelBuilder.Entity<AgentPhotographyCompany>()
                .HasKey(apc => new { apc.AgentId, apc.PhotographyCompanyId });

            modelBuilder.Entity<AgentPhotographyCompany>()
                .HasOne(apc => apc.Agent)
                .WithMany()
                .HasForeignKey(apc => apc.AgentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AgentPhotographyCompany>()
                .HasOne(apc => apc.PhotographyCompany)
                .WithMany()
                .HasForeignKey(apc => apc.PhotographyCompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<MediaAsset>()
                .HasOne(m => m.ListingCase)
                .WithMany()
                .HasForeignKey(m => m.ListingCaseId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<ListingCase>()
                .HasOne(lc => lc.PhotographyCompany)
                .WithMany()
                .HasForeignKey(lc => lc.PhotographyCompanyId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
