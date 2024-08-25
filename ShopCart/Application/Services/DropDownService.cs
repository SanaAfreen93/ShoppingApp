using ShopCart.Application.Interface;
using ShopCart.Domain.DataContext;
using ShopCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Services
{
    public class DropDownService : IDropDowns
    {
        private readonly ShopCartContext _dbContext;

        public DropDownService(ShopCartContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async  Task<List<RfRoleType>> getRoleTypeList()
        {
            return  _dbContext.RfRoleTypes.ToList() ;
        }
    }
}
