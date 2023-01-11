using mekashron.Models;

namespace mekashron.Services
{
    public interface ILoginService
    {
        Task<ServerResponse?> Login(string username, string password);
    }
}
