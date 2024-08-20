using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class Permission
{
    public int PermissionId { get; set; }

    public int ModuleId { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
