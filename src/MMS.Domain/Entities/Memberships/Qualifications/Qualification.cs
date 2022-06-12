using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Memberships.Qualifications;

public class Qualification 
{
    public GenericId Id { get; private set; }
    public QualificationName Name{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Qualification(GenericId id, QualificationName name, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    public Qualification()
    {
    }
    
    public void Create(GenericId id, QualificationName name, DateTime createdAt)
    {
         Id = id;
        Name = name;
        IsDeleted = false;
        CreatedAt = createdAt;
    }
    public void Update(QualificationName name)
    {
        Name = name;
    }
    
    public void Delete()
    {
        IsDeleted = true;
    }
}