using HealthcarePortalBackend.Ports.Storage;

namespace HealthcarePortalBackend.Adapters.Storage
{
    public class RegisteredUsersStorage : IRegisteredUsersStorage
    {
        private readonly RegisteredUsersContext _context;

        public RegisteredUsersStorage(RegisteredUsersContext context)
        {
            _context = context;
        }

        public void AddUser(string login, string password)
        {
            var registeredUser = new RegisteredUserRecord
            {
                Login = login,
                Password = password
            };
            _context.RegisteredUsers.Add(registeredUser);
            _context.SaveChanges();
        }
    }
}