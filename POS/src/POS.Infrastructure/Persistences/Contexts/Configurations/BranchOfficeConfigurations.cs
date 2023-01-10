using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configuration;

public class BranchOfficeConfigurations : IEntityTypeConfiguration<BranchOffice>
{
  public void Configure(EntityTypeBuilder<BranchOffice> builder)
  {
    throw new NotImplementedException();
  }
}