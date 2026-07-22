using Unit_Converter.Enums;

namespace Unit_Converter.Services.Interfaces
{
    public interface IConverterService
    {
        public string Convertunits(ConverterUnits converterType, double value);
    }
}
