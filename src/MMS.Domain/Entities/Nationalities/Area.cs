using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class Area
{
    public GenericId Id { get; private set; }
    public AreaName Name{ get; private set; }
    
    public GenericId StateId { get; private set; }
    public State State{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Area(GenericId id, AreaName name, GenericId stateId, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        StateId = stateId;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    private Area()
    {
    }
    
    public void  Update(AreaName name, GenericId stateId)
    {
        Name = name;
        StateId = stateId;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}