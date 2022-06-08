using System;

namespace MMS.Shared.Abstractions.Exceptions;

public abstract class MMSExceptions : Exception
{
    protected MMSExceptions(string message) : base(message)
    {
    }
}
