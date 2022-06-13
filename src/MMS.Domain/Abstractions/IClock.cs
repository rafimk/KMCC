using System;

namespace MMS.Domain.Abstractions;

public interface IClock
{
    DateTime Current();
}