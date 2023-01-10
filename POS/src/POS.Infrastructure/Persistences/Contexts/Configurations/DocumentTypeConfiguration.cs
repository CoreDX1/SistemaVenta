using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configuration.DistrictConfiguration;

public class DocumentTypeIdConfiguration : IEntityTypeConfiguration<DocumentType>
{
    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {
        builder.HasKey(e => e.DocumentTypeId).HasName("PK__Document__DBA390E14B38F678");

        builder.Property(e => e.Abbreviation).HasMaxLength(5).IsUnicode(false);
        builder.Property(e => e.Code).HasMaxLength(10).IsUnicode(false);
        builder.Property(e => e.Name).HasMaxLength(255).IsUnicode(false);
    }
}
