using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Dto
{
    public class ResponseBase<T>
    {
        public bool IsRequestSucessful { get; set; }
        public string? Error { get; set; }

        public T? Value { get; set; }
    }
}
