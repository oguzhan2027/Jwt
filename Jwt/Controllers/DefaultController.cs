using Jwt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
       
        [HttpGet("[Action]")]
        public IActionResult Login()
        {
            return Created("",new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("[Action]")]
        public IActionResult CustomerList()
        {
            return Ok("müşteri listesine eriştiniz");
        }
    }
}
