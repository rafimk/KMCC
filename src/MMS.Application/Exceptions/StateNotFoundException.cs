using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class StateNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public StateNotFoundException(Guid id) : base($"State Id {id} not found.")
    {
        Id = id;
    }
}