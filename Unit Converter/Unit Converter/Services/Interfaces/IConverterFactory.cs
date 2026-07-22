using Unit_Converter.Services.IServices;

namespace Unit_Converter.Services.Interfaces
{
    public interface IConverterFactory
    {
        public IUnitToConvert CreateConverter(string converterType);
    }
}
