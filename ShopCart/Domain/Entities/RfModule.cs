using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class RfModule
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;
}
