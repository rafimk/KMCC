using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record StateName
{
    public string Value { get; }

    public StateName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyStateNameException();
        }
        
        Value = value;
    }

    public static implicit operator string(StateName name)
        => name.Value;
    
    public static implicit operator StateName(string name)
        => new(name);
}
