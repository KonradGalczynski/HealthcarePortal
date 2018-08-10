using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HealthcarPortalBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post()
        {
            return new OkResult();
        }
    }
}