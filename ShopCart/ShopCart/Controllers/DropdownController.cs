using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopCart.Application.Interface;

namespace ShopCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {

        private IDropDowns _dropdownInterface;


        public DropdownController(IDropDowns dropDowns)
        {
            _dropdownInterface = dropDowns;
        }

        [HttpGet("rolelist")]
        [Authorize]
        public async Task<ActionResult> GetRoleList()
        {
            var data =await _dropdownInterface.getRoleTypeList();
            return Ok(data);    
        }
    }
}
