using AbstractMethod.DataFormatters;
using AbstractMethod.Generators;
using AbstractMethod.Interfaces;

namespace AbstractMethod.Factories;

public class UsaFactory : ICountryFactory
{
    public IReportGenerator CreateReportGenerator()
    {
        return new ExcelReportGenerator(CreateDataFormatter());
    }

    public ILocalizationProvider CreateLocalizationProvider()
    {
        return new UsaLocalization();
    }

    public IDataFormatter CreateDataFormatter()
    {
        return new BaseDataFormatter(CreateLocalizationProvider());
    }
}