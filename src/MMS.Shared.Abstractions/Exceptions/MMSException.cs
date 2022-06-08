using System;

namespace MMS.Shared.Abstractions.Exceptions;

public abstract class MMSException : Exception
{
    protected MMSException(string message) : base(message)
    {
    }
}
