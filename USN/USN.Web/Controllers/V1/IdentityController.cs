using Microsoft.AspNetCore.Mvc;
using System;
namespace USN.Web.Controllers.V1
{
    [ApiVersion("1.0")]
    public class IdentityController : ApiBaseController
    {
        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost("registration")]
        public IActionResult Registration()
        {
            return Ok();
        }

        [HttpPost("confirm")]
        public IActionResult Confirm()
        {
            return Ok();
        }

        [HttpPost("restore")]
        public IActionResult Restore()
        {
            return Ok();
        }

        [HttpGet("sessions")]
        public IActionResult GetSessions()
        {
            return Ok();
        }

        [HttpGet("sessions/{id}")]
        public IActionResult GetSessionById(Guid id)
        {
            return Ok();
        }

        [HttpDelete("sessions/{id}")]
        public IActionResult CloseSessionById(Guid id)
        {
            return Ok();
        }
    }
}