using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Districts;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Districts;

internal sealed class DeleteDistrictHandler : ICommandHandler<DeleteDistrict>
{
    private readonly IDistrictRepository _repository;

    public DeleteDistrictHandler(IDistrictRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeleteDistrict command)
    {
        var district = await _repository.GetByIdAsync(command.Id);

        if (district is null)
        {
            throw new DistrictNotFoundException(command.Id);
        }
        district.Delete();
        await _repository.UpdateAsync(district);
    }
}