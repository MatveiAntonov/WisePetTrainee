using Microsoft.EntityFrameworkCore;

namespace OrganizationsService.Models {
    public class OrganizationsDbContext : DbContext {
        public OrganizationsDbContext(DbContextOptions<OrganizationsDbContext> options)
            : base(options) { }

        public DbSet<Organization> Organizations => Set<Organization>();
    }
}
