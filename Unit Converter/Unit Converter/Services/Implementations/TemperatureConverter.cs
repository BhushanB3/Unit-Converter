using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class TemperatureConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            return "32.7F hai bhai";
        }
    }
}
