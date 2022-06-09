using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IQualificationRepository
{
    Task<Qualification> GetAsync(GenericId id);
    Task<IEnumerable<Qualification>> GetAllAsync();
    Task AddAsync(Qualification qualification);
    Task UpdateAsync(Qualification qualification);
    Task DeleteAsync(GenericId id);
}
