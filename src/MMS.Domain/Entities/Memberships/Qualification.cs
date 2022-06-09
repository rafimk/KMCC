using System;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Entities.Nationalities;

public class Profession 
{
    public GenericId Id { get; private set; }
    public QualificationName Name{ get; private set; }
    public bool IsDeleted { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Profession(GenericId id, QualificationName name, bool isDeleted, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
    }

    private Profession()
    {
    }
    
    public void  Profession(QualificationName name)
    {
        Name = name;
    }
    
    public void  Delete()
    {
        IsDeleted = true;
    }
}