using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class LengthConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            return "100m hai bhai";
        }
    }
}
