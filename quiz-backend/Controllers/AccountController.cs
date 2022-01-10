using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Controllers
{
    public class Credentials
    {
        public string UserName { get; set; }
        public string password { get; set; }
    }
    [Produces ("application/json")]
    [Route("api/Account")]
    //[ApiController]
    public class AccountController : Controller
    {
        readonly UserManager<IdentityUser> userManager;

        //sigin manager property in 
        readonly SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            //sigin mnager injection
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Credentials credentials)
        {
            
            var user = new IdentityUser { UserName = credentials.UserName, Email = credentials.UserName };

            var result = await userManager.CreateAsync(user, credentials.password);
            if (!result.Succeeded)

                return BadRequest(result.Errors);

            await signInManager.SignInAsync(user, isPersistent: false);
            var jwt = new JwtSecurityToken();   
            
            return Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
        }
    }
}
