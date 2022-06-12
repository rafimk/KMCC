using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class DistrictNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public DistrictNotFoundException(Guid id) : base($"District Id {id} not found.")
    {
        Id = id;
    }
}