using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Monitoreo.WebApi.Data.Queries;

public static partial class DevicesExtensions
{
    #region Generated Extensions
    public static Monitoreo.WebApi.Data.Entities.Devices? GetByKey(this System.Linq.IQueryable<Monitoreo.WebApi.Data.Entities.Devices> queryable, int id)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Monitoreo.WebApi.Data.Entities.Devices> dbSet)
            return dbSet.Find(id);

        return queryable.FirstOrDefault(q => q.Id == id);
    }

    public static async System.Threading.Tasks.ValueTask<Monitoreo.WebApi.Data.Entities.Devices?> GetByKeyAsync(this System.Linq.IQueryable<Monitoreo.WebApi.Data.Entities.Devices> queryable, int id, System.Threading.CancellationToken cancellationToken = default)
    {
        if (queryable is null)
            throw new ArgumentNullException(nameof(queryable));

        if (queryable is DbSet<Monitoreo.WebApi.Data.Entities.Devices> dbSet)
            return await dbSet.FindAsync(new object[] { id }, cancellationToken);

        return await queryable.FirstOrDefaultAsync(q => q.Id == id, cancellationToken);
    }

    #endregion

}
