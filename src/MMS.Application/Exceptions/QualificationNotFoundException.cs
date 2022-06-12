using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class QualificationNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public QualificationNotFoundException(Guid id) : base($"Qualification Id {id} not found.")
    {
        Id = id;
    }
}