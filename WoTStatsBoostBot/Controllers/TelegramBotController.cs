using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WoTStatsBoostBot.Controllers
{
    [Route("api/message/update")]
    [ApiController]
    public class TelegramBotController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Update([FromBody] object update)
        {

        }
    }
}
