using Unit_Converter.Enums;
using Unit_Converter.Services.Interfaces;

namespace Unit_Converter.Services
{
    public class ConverterService : IConverterService
    {
        private readonly IConverterFactory _converterFactory;

        public ConverterService(IConverterFactory converterFactory)
        {
            _converterFactory= converterFactory;
        }

        public string Convertunits(ConverterUnits unitType, double value)
        {
            var converter = _converterFactory.CreateConverter(unitType);
            if(converter != null)
            {
                var convertedValue = converter.Convert(value);
                return convertedValue;
            }
            else
            {
                return null;
            }
                
        }
    }
}
