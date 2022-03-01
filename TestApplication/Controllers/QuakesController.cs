using Microsoft.AspNetCore.Mvc;
using TestApplication.Interface;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuakesController : ControllerBase
    {
        private readonly IEarthquake _earthquake;
        public QuakesController(IEarthquake earthquake) 
        { 
            _earthquake = earthquake;
        }
        public JsonResult GetStates() 
        {
            return new JsonResult("respuesta");
        }
        public JsonResult GetCity()
        {
            return new JsonResult("respuesta");
        }
        public JsonResult GetEarthquakes()
        {
            return new JsonResult("respuesta");
        }
        public JsonResult GetStateEarthquakes()
        {
            return new JsonResult("respuesta");
        }
    }
}
