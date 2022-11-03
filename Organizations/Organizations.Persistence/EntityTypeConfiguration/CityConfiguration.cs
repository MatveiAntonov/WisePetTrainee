using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class CityConfiguration : IEntityTypeConfiguration<City> {
        public void Configure(EntityTypeBuilder<City> builder) {
            builder.ToTable("city");
        }
    }
}
