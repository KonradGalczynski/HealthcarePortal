namespace HealthcarePortalBackend.Ports.Storage
{
    public interface IRegisteredUsersStorage
    {
        void AddUser(string login, string password);
    }
}