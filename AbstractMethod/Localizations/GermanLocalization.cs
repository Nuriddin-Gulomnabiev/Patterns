using AbstractMethod.Interfaces;

namespace AbstractMethod;

public class GermanLocalization : ILocalizationProvider
{
    public string Language => "de-DE";

    public string CurrencySymbol => "€";
}