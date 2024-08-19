using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class Permission
{
    public int PermissionId { get; set; }

    public int ModuleId { get; set; }

    public int UserRoleMappingId { get; set; }

    public virtual UserRoleMapping UserRoleMapping { get; set; } = null!;
}
