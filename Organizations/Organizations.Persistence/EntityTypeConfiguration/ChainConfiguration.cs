using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizations.Domain.Entities;


namespace Organizations.Persistence.EntityTypeConfiguration {
    internal class ChainConfiguration : IEntityTypeConfiguration<Chain> {
        public void Configure(EntityTypeBuilder<Chain> builder) {
            builder.ToTable("chain");
        }
    }
}
