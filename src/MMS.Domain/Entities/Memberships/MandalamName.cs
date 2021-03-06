using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record MandalamName
{
    public string Value { get; }

    public MandalamName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyMandalamNameException();
        }
        
        Value = value;
    }

    public static implicit operator string(MandalamName name)
        => name.Value;
    
    public static implicit operator MandalamName(string name)
        => new(name);
}