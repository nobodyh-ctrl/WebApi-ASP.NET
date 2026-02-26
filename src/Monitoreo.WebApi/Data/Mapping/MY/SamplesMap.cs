using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Monitoreo.WebApi.Data.Mapping.MY;

public partial class SamplesMap
    : IEntityTypeConfiguration<Monitoreo.WebApi.Data.Entities.Samples>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Monitoreo.WebApi.Data.Entities.Samples> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("samples");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("id")
            .HasColumnType("int");

        // relationships
        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "";
        public const string Name = "samples";
    }

    public readonly struct Columns
    {
        public const string Id = "id";
    }
    #endregion
}
