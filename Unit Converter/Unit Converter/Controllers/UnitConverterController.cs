using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unit_Converter.Enums;
using Unit_Converter.Services.Interfaces;

namespace Unit_Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitConverterController : ControllerBase
    {

        private readonly IConverterFactory _converterFactory;

        public UnitConverterController(IConverterFactory converterFactory)
        {
            _converterFactory = converterFactory;
        }

        [HttpGet]
        [Route("Convert")]
        public IActionResult ConvertUnit([FromQuery] string unitType, [FromQuery] ConverterUnits value)
        {
            return Ok(null);
        }
    }
}
