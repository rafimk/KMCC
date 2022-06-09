using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record ProfessionName
{
    public string Value { get; }

    public StateName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyProfessionNameException();
        }
        
        Value = value;
    }

    public static implicit operator string(ProfessionName name)
        => name.Value;
    
    public static implicit operator ProfessionName(string name)
        => new(name);
}
