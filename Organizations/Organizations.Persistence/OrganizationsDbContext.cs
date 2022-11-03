using Microsoft.EntityFrameworkCore;
using Organizations.Application.Interfaces;
using Organizations.Domain.Entities;
using Organizations.Persistence.EntityTypeConfiguration;

namespace Organizations.Persistence {
    public class OrganizationsDbContext : DbContext, IOrganizationsDbContext {
        public DbSet<Organization> Organization { get; set; }
        public DbSet<OrganizationСategory> OrganizationCategory { get; set; }
        public DbSet<OrganizationСontact> OrganizationContact { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Street> Street { get; set; }
        public DbSet<Chain> Chain { get; set; }

        public OrganizationsDbContext(DbContextOptions<OrganizationsDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new OrganizationConfiguration());
            builder.ApplyConfiguration(new OrganizationCategoryConfiguration());
            builder.ApplyConfiguration(new OrganizationContactConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new StreetConfiguration());
            builder.ApplyConfiguration(new ChainConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
