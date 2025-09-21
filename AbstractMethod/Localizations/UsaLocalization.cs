using AbstractMethod.Interfaces;

namespace AbstractMethod;

public class UsaLocalization :  ILocalizationProvider
{
    public string Language => "en-US";

    public string CurrencySymbol => "$";
}