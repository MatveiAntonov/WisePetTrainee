using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;

namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class OrganizationConfiguration  : IEntityTypeConfiguration<Organization>{
        public void Configure(EntityTypeBuilder<Organization> builder) {
            builder.ToTable("organization");
        }
    }
}
