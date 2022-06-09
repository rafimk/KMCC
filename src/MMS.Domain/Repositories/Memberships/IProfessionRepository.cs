using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IProfessionRepository
{
    Task<Profession> GetAsync(GenericId id);
    Task<IEnumerable<Profession>> GetAllAsync();
    Task AddAsync(Profession profession);
    Task UpdateAsync(Profession profession);
    Task DeleteAsync(GenericId id);
}
