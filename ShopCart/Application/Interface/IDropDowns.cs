using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Interface
{
    public  interface IDropDowns
    {
        public Task<List<Domain.Entities.RfRoleType>> getRoleTypeList();
    }
}
