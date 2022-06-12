using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class PanchayatNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public PanchayatNotFoundException(Guid id) : base($"Panchayat Id {id} not found.")
    {
        Id = id;
    }
}