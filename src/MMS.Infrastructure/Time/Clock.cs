using System;
using MMS.Domain.Abstractions;

namespace MMS.Infrastructure.Time;

internal sealed class Clock : IClock
{
    public DateTime Current() => DateTime.UtcNow;
}