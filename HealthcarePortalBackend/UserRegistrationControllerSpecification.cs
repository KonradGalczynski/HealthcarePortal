using HealthcarePortalBackend.Controllers;
using HealthcarePortalBackend.Ports.Storage;
using HealthcarePortalBackendApi.DTO;
using NSubstitute;
using TddXt.AnyRoot;
using Xunit;

namespace HealthcarePortalBackendUnitSpecification.Controller
{
    public class UserRegistrationControllerSpecification
    {
        [Fact]
        public void ShouldStoreUserWhenRequested()
        {
            var registeredUsersStorage = Substitute.For<IRegisteredUsersStorage>();
            var userRegistrationController = new UserRegistrationController(registeredUsersStorage);

            var userRegistrationRequest = Root.Any.Instance<UserRegistrationRequest>();
            var response = userRegistrationController.AddUserToRegistered(userRegistrationRequest);

        }
    }
}
