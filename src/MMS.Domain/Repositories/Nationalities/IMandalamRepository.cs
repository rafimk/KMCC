using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IMandalamRepository
{
    Task<Mandalam> GetAsync(GenericId id);
    Task<IEnumerable<Mandalam>> GetAllAsync();
    Task AddAsync(Mandalam mandalam);
    Task UpdateAsync(Mandalam mandalam);
    Task DeleteAsync(GenericId id);
}
