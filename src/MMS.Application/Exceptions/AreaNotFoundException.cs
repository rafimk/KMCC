using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class AreaNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public AreaNotFoundException(Guid id) : base($"Area Id {id} not found.")
    {
        Id = id;
    }
}
