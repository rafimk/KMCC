using System.Threading.Tasks;
using MMS.Domain.Entities;
using MMS.Domain.ValueObjects;

namespace MMS.Domain.Repositories.Nationalities;

public interface IPanchayatRepository
{
    Task<Panchayat> GetAsync(GenericId id);
    Task<IEnumerable<Panchayat>> GetAllAsync();
    Task AddAsync(Panchayat panchayat);
    Task UpdateAsync(Panchayat panchayat);
    Task DeleteAsync(GenericId id);
}