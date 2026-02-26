using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Monitoreo.WebApi.Data;

public partial class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<Monitoreo.WebApi.Data.Entities.Devices> Devices { get; set; } = null!;

    public virtual DbSet<Monitoreo.WebApi.Data.Entities.Samples> Samples { get; set; } = null!;

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new Monitoreo.WebApi.Data.Mapping.MY.DevicesMap());
        modelBuilder.ApplyConfiguration(new Monitoreo.WebApi.Data.Mapping.MY.SamplesMap());
        #endregion
    }
}
