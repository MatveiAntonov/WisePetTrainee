using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class AddressConfiguration : IEntityTypeConfiguration<Address> {
        public void Configure(EntityTypeBuilder<Address> builder) {
            builder.ToTable("address");
        }
    }
}
