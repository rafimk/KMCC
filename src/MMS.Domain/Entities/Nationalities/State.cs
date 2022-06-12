using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class State 
{
    public GenericId Id { get; private set; }
    public StateName Name { get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private State(GenericId id, StateName name, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    public State()
    {
    }

    public void Create(GenericId id, StateName name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void Update(StateName name)
    {
        Name = name;
    }
    
    public void Delete()
    {
        IsDeleted = true;
    }
}
