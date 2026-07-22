using Unit_Converter.Enums;
using Unit_Converter.Services.Interfaces;
using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Factory
{
    public class ConverterFactory : IConverterFactory
    {
        public IUnitToConvert CreateConverter(ConverterUnits converterType)
        {
            switch(converterType)
            {
                case ConverterUnits.temperature:
                    return new TemperatureConverter();
                case ConverterUnits.length:
                    return new LengthConverter();
                case ConverterUnits.weight:
                    return new WeightConverter();
                default:
                    throw new ArgumentException("Invalid converter type");
            }
        }
    }
}
