using System.Text.RegularExpressions;
using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record MobileNumber
{
    public string Value { get; }

    public MobileNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyMobileNumberException();
        }

        if (!ValidateMobileNumber(value))
        {
            throw new InvalidateMobileNumberException();
        }
        
        Value = value;
    }
    
    private bool ValidateMobileNumber(string email)  
    {  
        Regex regex = new Regex(@"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$");  
        Match match = regex.Match(email); 
        
        return match.Success; 
    }  

    public static implicit operator string(MobileNumber name)
        => name.Value;
    
    public static implicit operator MobileNumber(string name)
        => new(name);
}