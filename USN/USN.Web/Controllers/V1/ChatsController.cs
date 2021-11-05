using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace USN.Web.Controllers.V1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ChatsController : ApiBaseController
    {
        #region Chats

        [HttpPost]
        public IActionResult CreateChat()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateChat(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteChat(int id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetChats(int page = 1)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetChatById(int id)
        {
            return Ok();
        }

        #endregion


        #region Members

        [HttpPost("{id}/members")]
        public IActionResult CreateChatMember(int id)
        {
            return Ok();
        }

        [HttpPut("{id}/members/{memberId}")]
        public IActionResult UpdateChatMember(int id, long memberId)
        {
            return Ok();
        }

        [HttpGet("{id}/members")]
        public IActionResult GetChatMembers(int id, int page = 1)
        {
            return Ok();
        }

        [HttpGet("{id}/members/{memberId}")]
        public IActionResult GetChatMember(int id, long memberId)
        {
            return Ok();
        }

        [HttpDelete("{id}/members/{memberId}")]
        public IActionResult DeleteChatMember(int id, long memberId)
        {
            return Ok();
        }

        #endregion


        #region Messages

        [HttpPost("{id}/messages")]
        public IActionResult CreateChatMessage(int id)
        {
            return Ok();
        }

        [HttpPut("{id}/messages/{messageId}")]
        public IActionResult UpdateChatMessage(int id, long messageId)
        {
            return Ok();
        }

        [HttpGet("{id}/messages")]
        public IActionResult GetChatMessages(int id, int page)
        {
            return Ok();
        }

        [HttpGet("{id}/messages/{messageId}")]
        public IActionResult GetChatMessageById(int id, long messageId)
        {
            return Ok();
        }

        [HttpPost("{id}/messages/{messageId}/forward")]
        public IActionResult ForwardChatMessage(int id, long messageId)
        {
            return Ok();
        }

        [HttpGet("{id}/messages/{messageId}/replies")]
        public IActionResult GetChatMessageReplies(int id, long messageId)
        {
            return Ok();
        }

        [HttpDelete("{id}/messages/{messageId}")]
        public IActionResult DeleteChatMessage(int id, long messageId)
        {
            return Ok();
        }

        #endregion
    }
}