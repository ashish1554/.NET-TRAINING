using DAY1.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DAY1.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ISingletonService _singleton1;
        private readonly ISingletonService _singleton2;

        private readonly ITransientService _transient1;
        private readonly ITransientService _transient2;

        private readonly IScopedService _scoped1;
        private readonly IScopedService _scoped2;




        public HomeController
            (
             ISingletonService singleton1,ISingletonService singleton2,
             ITransientService transient1,ITransientService transient2,
             IScopedService scoped1,IScopedService scoped2
            )
        {
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _transient1 = transient1;
            _transient2 = transient2;
            _scoped1 = scoped1;
            _scoped2 = scoped2;
        }

        [HttpGet("api/lifetime")]
        public IActionResult GetGuid() 
        {
            return Ok(new
            {
                singleton1 = _singleton1.GetGuid(),
                singleton2 = _singleton2.GetGuid(),
                transient1 = _transient1.GetGuid(),
                transient2 = _transient2.GetGuid(),
                scoped1 = _scoped1.GetGuid(),
                scoped2 = _scoped2.GetGuid(),

            });
        }
    }
}
