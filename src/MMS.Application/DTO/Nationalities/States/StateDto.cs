using System;
using MMS.Domain.ValueObjects;

namespace MMS.Application.DTO.Nationalities.States;

public class StateDto 
{
    public GenericId Id { get; private set; }
    public string Name { get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }
}