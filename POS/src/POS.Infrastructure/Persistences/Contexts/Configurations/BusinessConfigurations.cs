using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configuration.BusinessConfigurations;

public class BusinessConfigurations : IEntityTypeConfiguration<Business>
{
    public void Configure(EntityTypeBuilder<Business> builder)
    {
        builder.HasKey(e => e.BusinessId).HasName("PK__Business__F1EAA36E4F215095");

        builder.ToTable("Business");

        builder.Property(e => e.Address).IsUnicode(false);
        builder.Property(e => e.BusinessName).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.Code).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.CreationDate).HasColumnType("datetime");
        builder.Property(e => e.Email).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.Logo).IsUnicode(false);
        builder.Property(e => e.Mision).IsUnicode(false);
        builder.Property(e => e.Phone).HasMaxLength(100).IsUnicode(false);
        builder.Property(e => e.Ruc).HasMaxLength(11).IsUnicode(false);
        builder.Property(e => e.Vision).IsUnicode(false);

        builder
            .HasOne(d => d.District)
            .WithMany(p => p.Businesses)
            .HasForeignKey(d => d.DistrictId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Business__Distri__4AB81AF0");
    }
}
