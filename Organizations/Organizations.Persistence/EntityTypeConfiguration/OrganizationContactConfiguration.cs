using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class OrganizationContactConfiguration : IEntityTypeConfiguration<OrganizationСontact> {
        public void Configure(EntityTypeBuilder<OrganizationСontact> builder) {
            builder.ToTable("organization_contact");
        }
    }
}
