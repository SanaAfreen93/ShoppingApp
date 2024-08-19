using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class Role
{
    public int RoleId { get; set; }

    public byte[]? RoleName { get; set; }

    public int RoleType { get; set; }

    public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; } = new List<UserRoleMapping>();
}
