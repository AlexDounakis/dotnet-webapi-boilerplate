using Finbuckle.MultiTenant.EntityFrameworkCore;
using FSH.WebApi.Domain.Survey;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSH.WebApi.Infrastructure.Persistence.Configuration;

public class FormConfig : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.HasKey(t => t.Id);
        builder.HasAlternateKey("FormId");

        builder.ToTable("Forms", SchemaNames.Survey)
            .IsMultiTenant();
    }
}