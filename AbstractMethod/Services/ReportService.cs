using AbstractMethod.Interfaces;

namespace AbstractMethod.Services;

public class ReportService
{
    private readonly IReportGenerator _reportGenerator;
    
    public ReportService(ICountryFactory countryFactory)
    {
        _reportGenerator  = countryFactory.CreateReportGenerator();
    }

    public void Report(decimal amount, DateTime date)
    {
        _reportGenerator.GenerateReport(amount, date);
    }
}