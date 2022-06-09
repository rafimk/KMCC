using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record PassportNumber
{
    public string Value { get; }

    public EmiratesIdNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyPassportNumberException();
        }
        
        Value = value;
    }

    public static implicit operator string(PassportNumber passportNumber)
        => passportNumber.Value;
    
    public static implicit operator PassportNumber(string passportNumber)
        => new(passportNumber);
}