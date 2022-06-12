using System.Collections.Generic;
using System.Threading.Tasks;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IPanchayatRepository
{
    Task<Panchayat> GetByIdAsync(GenericId id);
    Task<IEnumerable<Panchayat>> GetByMandalamIdAllAsync(GenericId mandalamId);
    Task<IEnumerable<Panchayat>> GetAsync();
    Task AddAsync(Panchayat panchayat);
    Task UpdateAsync(Panchayat panchayat);
}