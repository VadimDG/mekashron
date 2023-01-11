using mekashron.Models;
using Newtonsoft.Json;

namespace mekashron.Services
{
    public class LoginService: ILoginService
    {
        public async Task<ServerResponse?> Login(string username, string password)
        {
            ServiceReference1.ICUTechClient client = new ServiceReference1.ICUTechClient();
            var res = await client.LoginAsync(username, password, "");

            return string.IsNullOrWhiteSpace(res.@return) ? null : JsonConvert.DeserializeObject<ServerResponse>(res.@return);
        }
    }
}
