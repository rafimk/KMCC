using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IStateRepository
{
    Task<State> GetAsync(GenericId id);
    Task<IEnumerable<State>> GetAllAsync();
    Task AddAsync(State state);
    Task UpdateAsync(State state);
    Task DeleteAsync(GenericId id);
}
