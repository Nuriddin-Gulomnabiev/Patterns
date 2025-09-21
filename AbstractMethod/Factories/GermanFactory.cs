using AbstractMethod.DataFormatters;
using AbstractMethod.Generators;
using AbstractMethod.Interfaces;

namespace AbstractMethod.Factories;

public class GermanFactory : ICountryFactory
{
    public IReportGenerator CreateReportGenerator()
    {
        return new PdfReportGenerator(CreateDataFormatter());
    }

    public ILocalizationProvider CreateLocalizationProvider()
    {
        return new GermanLocalization();
    }

    public IDataFormatter CreateDataFormatter()
    {
        return new BaseDataFormatter(CreateLocalizationProvider());
    }
}