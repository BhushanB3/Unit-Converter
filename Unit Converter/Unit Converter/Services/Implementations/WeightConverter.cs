using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Implementations
{
    public class WeightConverter : IUnitToConvert
    {
        public string Convert(double value)
        {
            return "50kg hai bhai";
        }
    }
}
