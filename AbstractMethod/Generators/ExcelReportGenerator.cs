using AbstractMethod.Interfaces;

namespace AbstractMethod.Generators;

public class ExcelReportGenerator : IReportGenerator
{
    private readonly IDataFormatter _formatter;

    public ExcelReportGenerator(IDataFormatter formatter)
    {
        _formatter = formatter;
    }
    
    public void GenerateReport(decimal amount, DateTime date)
    {
        Console.WriteLine("=== EXCEL REPORT ===");
        Console.WriteLine($"[CELL A1] { _formatter.FormatAmount(amount) }");
        Console.WriteLine($"[CELL A2] { _formatter.FormatDateTime(date) }");
        Console.WriteLine("==================");
    }
}