using Unit_Converter.Constants;
using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class TemperatureConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            var convertedvalue = (value * ConversionConstants.CelciusToFahrenitMultipler) + ConversionConstants.CelciusToFahrenitAddition;
            return convertedvalue.ToString() +" Fahrenit";
        }
    }
}
