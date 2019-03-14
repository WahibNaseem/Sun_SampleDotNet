using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleDotNet.API.Dtos;

namespace SampleDotNet.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController:ControllerBase
    {
        

       /*  [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
           userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

           if(await true)
              return BadRequest("UserName already exists");
        }*/

       /*  [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {

        }*/

    }
}