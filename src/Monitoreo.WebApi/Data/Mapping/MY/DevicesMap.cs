using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Monitoreo.WebApi.Data.Mapping.MY;

public partial class DevicesMap
    : IEntityTypeConfiguration<Monitoreo.WebApi.Data.Entities.Devices>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Monitoreo.WebApi.Data.Entities.Devices> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("devices");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Alias)
            .HasColumnName("alias")
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Community)
            .HasColumnName("community")
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.Disabled)
            .HasColumnName("disabled")
            .HasColumnType("tinyint");

        builder.Property(t => t.Deleted)
            .HasColumnName("deleted")
            .HasColumnType("tinyint")
            .HasDefaultValueSql("'0'");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "";
        public const string Name = "devices";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
        public const string Name = "name";
        public const string Alias = "alias";
        public const string Community = "community";
        public const string Disabled = "disabled";
        public const string Deleted = "deleted";
    }
    #endregion
}
