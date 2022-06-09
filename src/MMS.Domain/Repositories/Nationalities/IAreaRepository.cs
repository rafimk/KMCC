using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IAreaRepository
{
    Task<Area> GetAsync(GenericId id);
    Task<IEnumerable<Area>> GetAllAsync();
    Task AddAsync(Area area);
    Task UpdateAsync(Area area);
    Task DeleteAsync(GenericId id);
}
