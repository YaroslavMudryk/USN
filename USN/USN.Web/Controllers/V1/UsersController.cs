using Microsoft.AspNetCore.Mvc;

namespace USN.Web.Controllers.V1
{
    [ApiVersion("1.0")]
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            return Ok();
        }

        [HttpGet("me")]
        public IActionResult GetMe()
        {
            return Ok();
        }

        [HttpGet("{id}/friends")]
        public IActionResult GetUserFriends(int id, int page)
        {
            return Ok();
        }
    }
}