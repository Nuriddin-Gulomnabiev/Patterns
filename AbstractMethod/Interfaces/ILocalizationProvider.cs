using System.Globalization;

namespace AbstractMethod.Interfaces;

public interface ILocalizationProvider
{
    string Language { get; }
    string CurrencySymbol { get; }
    
    CultureInfo GetCultureInfo() => new CultureInfo(Language);
}