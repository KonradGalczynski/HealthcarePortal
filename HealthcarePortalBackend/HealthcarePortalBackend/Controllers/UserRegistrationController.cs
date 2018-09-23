using HealthcarePortalBackend.Model;
using HealthcarePortalBackendApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HealthcarePortalBackend.Controllers
{
    [Route("api/registration")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly RegisteredUsersContext _context;

        public UserRegistrationController(RegisteredUsersContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("user")]
        public ActionResult Post([FromBody] UserRegistrationRequest userRegistrationRequest)
        {
            var registeredUser = new RegisteredUserRecord
            {
                Login = userRegistrationRequest.Login,
                Password = userRegistrationRequest.Password
            };
            _context.RegisteredUsers.Add(registeredUser);
            _context.SaveChanges();

            return new OkResult();
        }
    }
}