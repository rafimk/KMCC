using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class MandalamNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public MandalamNotFoundException(Guid id) : base($"Mandalam Id {id} not found.")
    {
        Id = id;
    }
}