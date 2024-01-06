using CurrenyConverter.DTO;
using CurrenyConverter.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CurrenyConverter.Controllers
{
    public class ConvertCurrencyController : Controller
    {
        private IConverter currencyConverter { get; set; }

        public ConvertCurrencyController(IConverter currencyConverter)
        {
            this.currencyConverter = currencyConverter;
        }

        //https://localhost:7014/INR/100/USD

        [HttpGet("{from_currency}/{from_currency_amount:double}/{to_currency}")]
        public IActionResult Index(string from_currency, double from_currency_amount, string to_currency)
        {
            ConvertRequest convertRequest = new ConvertRequest
            {
                from_currency = from_currency,
                from_currency_amount = from_currency_amount,
                to_currency = to_currency 
            };
                
            ConvertResponse response = currencyConverter.PerformConversion(convertRequest);
            return Json(response);
        }
    }
}