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

        private readonly IConverterService _converterService;

        public UnitConverterController(IConverterService converterService)
        {
            _converterService = converterService;
        }

        [HttpGet]
        [Route("Convert")]
        public IActionResult ConvertUnit([FromQuery] double value, [FromQuery] ConverterUnits unitType)
        {
            var result = _converterService.Convertunits(unitType, value);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid unit type or value.");
            }
        }
    }
}
