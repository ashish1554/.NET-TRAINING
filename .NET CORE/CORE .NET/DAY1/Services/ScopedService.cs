using DAY1.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace DAY1.Services
{
    public class ScopedService : IScopedService
    {
        private readonly string _id = Guid.NewGuid().ToString();
        public  string GetGuid()
        {
            return _id;
        }
    }
}
