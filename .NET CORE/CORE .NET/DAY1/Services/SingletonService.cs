using DAY1.Interfaces;

namespace DAY1.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly string _id = Guid.NewGuid().ToString();
        public string GetGuid()
        {
            return _id;
        }
    }
}
