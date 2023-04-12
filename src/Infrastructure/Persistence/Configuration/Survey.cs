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

public class InfoConfig : IEntityTypeConfiguration<Info>
{
    public void Configure(EntityTypeBuilder<Info> builder)
    {
        builder.ToTable("Info", SchemaNames.Survey);
            //.IsMultiTenant();
    }
}

public class ItemConfig : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Items", SchemaNames.Survey);
            //.IsMultiTenant();
    }
}

public class SettingsConfig : IEntityTypeConfiguration<Settings>
{
    public void Configure(EntityTypeBuilder<Settings> builder)
    {
        builder.ToTable("Settings", SchemaNames.Survey);
            //.IsMultiTenant();
    }
}

public class QuizSettingsConfig : IEntityTypeConfiguration<QuizSettings>
{
    public void Configure(EntityTypeBuilder<QuizSettings> builder)
    {
        builder.ToTable("QuizSettings", SchemaNames.Survey);
            //.IsMultiTenant();
    }
}
