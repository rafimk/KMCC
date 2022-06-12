using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Districts;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Districts;

internal sealed class UpdateDistrictHandle : ICommandHandler<UpdateDistrict>
{
    private readonly IDistrictRepository _repository;

    public UpdateDistrictHandle(IDistrictRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateDistrict command)
    {
        var district = await _repository.GetByIdAsync(command.Id);

        if (district is null)
        {
            throw new DistrictNotFoundException(command.Id);
        }
        district.Update(command.Name);
        await _repository.UpdateAsync(district);
    }
}