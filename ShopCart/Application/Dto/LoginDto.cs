using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Dto
{
    public class LoginDto
    {
        public bool IsRequestSucessful { get; set; }
        public string? accesstoken { get; set; }

        public string? error { get; set; }

        public string? message { get; set; }
    }
}
