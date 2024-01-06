using CurrenyConverter.DTO;

namespace CurrenyConverter.Interface
{
    public interface IConverter
    {
        ConvertResponse PerformConversion(ConvertRequest convertRequest);
    }
}