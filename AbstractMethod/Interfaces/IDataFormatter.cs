namespace AbstractMethod.Interfaces;

public interface IDataFormatter
{
    string FormatDateTime(DateTime dt);
    string FormatAmount(decimal amount);
}