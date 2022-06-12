using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Panchayats;
using MMS.Application.Exceptions;
using MMS.Domain.Consts;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Panchayats;

internal sealed class UpdatePanchayatHandler : ICommandHandler<UpdatePanchayat>
{
    private readonly IPanchayatRepository _repository;

    public UpdatePanchayatHandler(IPanchayatRepository repository)
        => _repository = repository;

    public async Task HandleAsync(UpdatePanchayat command)
    {
        var mandalam = await _repository.GetByIdAsync(command.Id);

        if (mandalam is null)
        {
            throw new DistrictNotFoundException(command.Id);
        }
        mandalam.Update(command.Name, command.MandalamId, (PanchayatType)command.Type);
        await _repository.UpdateAsync(mandalam);
    }
}