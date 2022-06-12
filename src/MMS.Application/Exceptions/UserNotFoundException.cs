using System;
using MMS.Shared.Abstractions.Exceptions;

namespace MMS.Application.Exceptions;

public class UserNotFoundException : MMSException
{
    public Guid Id { get; }
    
    public UserNotFoundException(Guid id) : base($"User Id {id} not found.")
    {
        Id = id;
    }
}