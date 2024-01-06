using CurrenyConverter.DTO;

namespace CurrenyConverter.Interface
{
    public class Converter : IConverter
    {
        public ConvertResponse PerformConversion(ConvertRequest convertRequest)
        {
            double to_currency_amount = 0.00;
            ConvertResponse convertResponse = new ConvertResponse();
            convertResponse.from_currency = convertRequest.from_currency;
            convertResponse.from_currency_amount = convertRequest.from_currency_amount;
            convertResponse.to_currency = convertRequest.to_currency;
            convertResponse.conversion_rate = 82.34;
            switch (convertRequest.from_currency)
            {
                case "INR":
                    to_currency_amount = (convertResponse.from_currency_amount / convertResponse.conversion_rate);                    
                    convertResponse.to_currency_amount = Convert.ToDouble(to_currency_amount.ToString("N2"));
                    break;
                default:
                    break;
            }
            return convertResponse;
        }
    }
}
