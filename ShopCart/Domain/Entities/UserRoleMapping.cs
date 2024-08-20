﻿using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class UserRoleMapping
{
    public int UserRoleMappingId { get; set; }

    public int RoleId { get; set; }

    public int UserId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
