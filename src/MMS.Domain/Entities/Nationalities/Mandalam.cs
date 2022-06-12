using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class Mandalam
{
    public GenericId Id { get; private set; }
    public MandalamName Name{ get; private set; }
    public GenericId DistrictId { get; private set; }
    public District District{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Mandalam(GenericId id, MandalamName name, GenericId districtId, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        DistrictId = districtId;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    public Mandalam()
    {
    }

    public void Create(GenericId id, MandalamName name, GenericId districtId, DateTime createdAt)
    {
        Id = id;
        Name = name;
        DistrictId = districtId;
        IsDeleted = false;
        CreatedAt = createdAt;
    }

    public void Update(MandalamName name, GenericId districtId)
    {
        Name = name;
        DistrictId = districtId;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}