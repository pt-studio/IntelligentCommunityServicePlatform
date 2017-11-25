using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntelligentCommunityServicePlatform.Controllers
{
    [Produces("application/json")]
    [Route("api/Stream")]
    public class StreamController : Controller
    {
        [HttpGet("GenerateId")]
        public IActionResult GenerateId()
        {
            var guid = Guid.NewGuid();
            return new ObjectResult(guid.ToString("N").Normalize());
        }
    }
}