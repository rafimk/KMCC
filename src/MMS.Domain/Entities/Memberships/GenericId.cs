using System;
using MMS.Domain.Exceptions;

namespace MMS.Domain.ValueObjects;

public record GenericId
{
    public Guid Value { get; }

    public GenericId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new EmptyGenericIdException();
        }
        
        Value = value;
    }
    
    public static implicit operator Guid(GenericId id)
        => id.Value;
    
    public static implicit operator GenericId(Guid id)
        => new(id);
}
