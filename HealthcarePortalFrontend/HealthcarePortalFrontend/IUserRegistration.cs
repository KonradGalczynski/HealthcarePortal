using System.Net.Http;
using System.Threading.Tasks;
using Refit;

namespace HealthcarePortalFrontend
{
    internal interface IUserRegistration
    {
        [Post("/api/registration/user")]
        Task<HttpResponseMessage> Post([Body] UserRegistrationRequest userRegistrationRequest);
    }
}