namespace POS.Infrastructure.Persistences.Contexts.Configuration.MenuConfiguration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.HasKey(e => e.MenuId).HasName("PK__Menus__C99ED2301BE0FEE2");

        builder.Property(e => e.Icon).HasMaxLength(50).IsUnicode(false);
        builder.Property(e => e.Name).HasMaxLength(150).IsUnicode(false);
        builder.Property(e => e.Url).HasMaxLength(150).IsUnicode(false).HasColumnName("URL");
    }
}
