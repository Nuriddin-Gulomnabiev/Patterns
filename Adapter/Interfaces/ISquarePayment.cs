namespace Adapter.Interfaces;

public interface ISquarePayment
{
    void MakePayment(decimal amount, string currency);
}