using System.Text.RegularExpressions;
using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyEmailException();
        }

        if (!ValidateEmail(value))
        {
            throw new InvalidEmailException();
        }
        
        Value = value;
    }
    
    private bool ValidateEmail(string email)  
    {  
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");  
        Match match = regex.Match(email); 
        
        return match.Success; 
    }  

    public static implicit operator string(Email name)
        => name.Value;
    
    public static implicit operator Email(string name)
        => new(name);
}