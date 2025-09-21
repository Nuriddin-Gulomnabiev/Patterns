namespace Prototype;

public class Person
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;

    public Person ShallowCopy()
    {
        return (Person)MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = string.Copy(Name);
        return clone;
    }

    public override string ToString()
    {
        return $"ID#: {IdInfo.IdNumber}, Name: {Name}, Age: {Age}, BirthDate: {BirthDate:MM/dd/yy}";
    }
}