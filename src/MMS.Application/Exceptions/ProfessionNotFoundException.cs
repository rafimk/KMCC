using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class ProfessionNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public ProfessionNotFoundException(Guid id) : base($"Profession Id {id} not found.")
    {
        Id = id;
    }
}