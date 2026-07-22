using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class LengthConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            var convertedValue = value * Constants.ConversionConstants.MetersToFeet;
            return convertedValue.ToString() + " Feet";
        }
    }
}
