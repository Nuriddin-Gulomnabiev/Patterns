using AbstractMethod.Interfaces;

namespace AbstractMethod.DataFormatters;

public class BaseDataFormatter : IDataFormatter
{
    private readonly ILocalizationProvider _localizationProvider;
    
    public BaseDataFormatter(ILocalizationProvider localizationProvider)
    {
        _localizationProvider = localizationProvider;
    }
    
    public string FormatDateTime(DateTime dt)
    {
        return dt.ToString(_localizationProvider.GetCultureInfo());
    }

    public string FormatAmount(decimal amount)
    {
        var culture = _localizationProvider.GetCultureInfo();
        var currency = _localizationProvider.CurrencySymbol;
        
        return $"{amount.ToString("N2", culture)} {currency}";
    }
}