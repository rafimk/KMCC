using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Memberships.Professions;

public class Profession 
{
    public GenericId Id { get; private set; }
    public ProfessionName Name{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Profession(GenericId id, ProfessionName name, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    public Profession()
    {
    }
    
    public void Create(GenericId id, ProfessionName name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    public void Update(ProfessionName name)
    {
        Name = name;
    }
    
    public void Delete()
    {
        IsDeleted = true;
    }
}