namespace AbstractMethod.Interfaces;

public interface ICountryFactory
{
    IReportGenerator CreateReportGenerator();
    ILocalizationProvider  CreateLocalizationProvider();
    IDataFormatter CreateDataFormatter();
}