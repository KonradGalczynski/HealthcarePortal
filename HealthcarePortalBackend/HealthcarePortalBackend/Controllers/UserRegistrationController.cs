using HealthcarePortalBackend.Ports.Storage;
using HealthcarePortalBackendApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HealthcarePortalBackend.Controllers
{
    [Route("api/registration")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IRegisteredUsersStorage _registeredUsersStorage;

        public UserRegistrationController(IRegisteredUsersStorage registeredUsersStorage)
        {
            _registeredUsersStorage = registeredUsersStorage;
        }

        [HttpPost]
        [Route("user")]
        public ActionResult Post([FromBody] UserRegistrationRequest userRegistrationRequest)
        {
            _registeredUsersStorage.AddUser(userRegistrationRequest.Login,
                userRegistrationRequest.Password);

            return new OkResult();
        }
    }
}