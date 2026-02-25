using System;
using System.Collections.Generic;

namespace Monitoreo.WebApi.Data.Entities;

public partial class Devices
{
    public Devices()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Alias { get; set; }

    public string? Community { get; set; }

    public sbyte? Disabled { get; set; }

    public sbyte? Deleted { get; set; }

    #endregion

    #region Generated Relationships
    #endregion

}
