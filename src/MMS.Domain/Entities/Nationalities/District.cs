using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class District
{
    public GenericId Id { get; private set; }
    public DistrictName Name{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private District(GenericId id, DistrictName name, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    public District()
    {
    }

    public void Create(GenericId id, DistrictName name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    
    public void Update(DistrictName name)
    {
        Name = name;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}