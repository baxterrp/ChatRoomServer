using Chatroom.Server.EntityContext;
using Chatroom.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Chatroom.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly UserManager<MessengerUser> _userManager;

        public MessageController(UserManager<MessengerUser> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] MessagePackage messagePackage)
        {
            return Ok();
        }
    }
}
