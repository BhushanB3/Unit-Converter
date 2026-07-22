using Unit_Converter.Constants;
using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class WeightConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            var convertedValue = value * ConversionConstants.KilogramToPound;
            return convertedValue.ToString() + " Pounds";
        }
    }
}
