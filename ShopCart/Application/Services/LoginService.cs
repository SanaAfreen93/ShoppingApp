using Microsoft.IdentityModel.Tokens;
using ShopCart.Application.Dto;
using ShopCart.Application.Interface;
using ShopCart.Domain.DataContext;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShopCart.Application.Services
{
    public  class LoginService : ILoginInterface
    {

        private readonly ShopCartContext _dbContext;

        public LoginService(ShopCartContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  String login(UserDto model)
        {
            try
            {
                var data  = _dbContext.Users.Where(x => x.UserName == model.UserName).FirstOrDefault();
                if (model.UserName == data.UserName && model.Password == data.Password)
                {
                    // Ensure the secret key is at least 256 bits (32 characters for UTF-8 encoding)
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("yourSuperSecretKeyThatIsAtLeast32CharsLong"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokenOptions = new JwtSecurityToken(
                        issuer: "CodeMaze",
                        audience: "https://localhost:5081",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(5),
                        signingCredentials: signinCredentials
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                    return tokenString;
                }
                else
                {
                    return "Unable to generate token. Please check your credentials.";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public async  Task<ResponseBase<UserDto>> SaveUserDetails(UserDto users)
        {
            try
            {
                var userDetails = (new UserDto
                {
                    UserName = users.UserName,
                    Email = users.Email,
                    Password = users.Password,
                    Mobile = users.Mobile,
                    Status = 1,

                });

                _dbContext.Add(userDetails);

                var roleDetails = (new RoleDto
                {
                    RoleType = users.RoleTypeId

                });
                _dbContext.Add(roleDetails);

                var UserRoleMappingDetails = (new UserRoleMappingDto
                {
                    RoleId = roleDetails.RoleId,
                    UserId = userDetails.UserId,
                });
                _dbContext.Add(UserRoleMappingDetails);

                await _dbContext.SaveChangesAsync();

                return new ResponseBase<UserDto> { IsRequestSucessful = true, Value = new UserDto() { UserId = userDetails.UserId } };
            }
            catch (Exception ex)
            {
                return new ResponseBase<UserDto> { IsRequestSucessful = false,Error = ex.Message };
            }

          
        }
    }
}
