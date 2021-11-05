using Microsoft.AspNetCore.Mvc;
using System;

namespace USN.Web.Controllers.V1
{
    [ApiVersion("1.0")]
    public class NotificationsController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetNotifications(int page = 1)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetNotificationById(Guid id)
        {
            return Ok();
        }

        [HttpPost("setup")]
        public IActionResult SetupUserNotification()
        {
            return Ok();
        }
    }
}
