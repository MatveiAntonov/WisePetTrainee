using Microsoft.EntityFrameworkCore;

namespace OrganizationsService.Models {
    public class OrganizationsDbContext : DbContext {
        public OrganizationsDbContext(DbContextOptions<OrganizationsDbContext> options)
            : base(options) { }

        public DbSet<Organization> Organization => Set<Organization>();
        public DbSet<Organization_category> Organization_category => Set<Organization_category>();
        public DbSet<Organization_contact> Organization_contact => Set<Organization_contact>();
        public DbSet<Address> Address => Set<Address>();
        public DbSet<City> City => Set<City>();
        public DbSet<Street> Street => Set<Street>();
        public DbSet<Chain> Chain => Set<Chain>();
    }
}
