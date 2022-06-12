using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IStateRepository
{
    Task<State> GetByIdAsync(GenericId id);
    Task<IEnumerable<State>> GetAsync();
    Task AddAsync(State state);
    Task UpdateAsync(State state);
}
