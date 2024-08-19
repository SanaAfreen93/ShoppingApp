using System;
using System.Collections.Generic;

namespace ShopCart.Domain.Entities;

public partial class RfRoleType
{
    public int Id { get; set; }

    public string RoleType { get; set; } = null!;
}
