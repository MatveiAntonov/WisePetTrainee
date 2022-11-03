using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class StreetConfiguration : IEntityTypeConfiguration<Street> {
        public void Configure(EntityTypeBuilder<Street> builder) {
            builder.ToTable("street");
        }
    }
}
