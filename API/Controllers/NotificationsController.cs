using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class NotificationsController : ControllerBase
    {
        private readonly FirebaseNotificationService _notificationService;
        private static readonly List<string> _tokens = new List<string>();
        public NotificationsController(FirebaseNotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("save-token")]
        public async Task<IActionResult> SaveToken([FromBody] TokenRequest request)
        {
            if (string.IsNullOrEmpty(request.Token))
            {
                return BadRequest("Token is required.");
            }

            // Store the token (e.g., in a database)
            _tokens.Add(request.Token);

            return Ok(new { message = "Token saved successfully." });
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request)
        {
            foreach (var token in _tokens)
            {
                await _notificationService.SendNotificationAsync(token, request.Title, request.Body);
            }
            return Ok("Notification sent successfully.");
        }
    }
}
