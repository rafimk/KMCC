using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Mandalams;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Mandalams;

internal sealed class UpdateMandalamHandler : ICommandHandler<UpdateMandalam>
{
    private readonly IMandalamRepository _repository;

    public UpdateMandalamHandler(IMandalamRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdateMandalam command)
    {
        var mandalam = await _repository.GetByIdAsync(command.Id);

        if (mandalam is null)
        {
            throw new DistrictNotFoundException(command.Id);
        }
        mandalam.Update(command.Name, command.DistrictId);
        await _repository.UpdateAsync(mandalam);
    }
}