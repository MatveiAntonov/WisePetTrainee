using Microsoft.EntityFrameworkCore;
using Organizations.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Organizations.Application.Interfaces {
    public interface IOrganizationsDbContext {
        DbSet<Organizations.Domain.Entities.Organization> Organization { get; set; }
        DbSet<OrganizationСategory> OrganizationCategory { get; set; }
        DbSet<OrganizationСontact> OrganizationContact { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<City> City { get; set; }
        DbSet<Street> Street { get; set; }
        DbSet<Chain> Chain { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
