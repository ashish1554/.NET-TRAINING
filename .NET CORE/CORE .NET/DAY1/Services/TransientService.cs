using DAY1.Interfaces;

namespace DAY1.Services
{
    public class TransientService:ITransientService
    {
        private readonly string _id = Guid.NewGuid().ToString();
        public string GetGuid()
        {
            return _id;
        }
    }
}
