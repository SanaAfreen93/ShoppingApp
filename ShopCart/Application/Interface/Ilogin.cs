using ShopCart.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Interface
{
    public  interface ILoginInterface
    {

        public String login(UserDto user);
    }
}
