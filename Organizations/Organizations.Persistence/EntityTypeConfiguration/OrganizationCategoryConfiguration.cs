using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class OrganizationCategoryConfiguration : IEntityTypeConfiguration<OrganizationСategory> {
        public void Configure(EntityTypeBuilder<OrganizationСategory> builder) {
            builder.ToTable("organization_category");
        }
    }
}
