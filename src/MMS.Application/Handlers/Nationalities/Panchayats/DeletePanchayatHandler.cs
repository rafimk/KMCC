using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Panchayats;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Panchayats;

internal sealed class DeletePanchayatHandler : ICommandHandler<DeletePanchayat>
{
    private readonly IPanchayatRepository _repository;

    public DeletePanchayatHandler(IPanchayatRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeletePanchayat command)
    {
        var panchayat = await _repository.GetByIdAsync(command.Id);

        if (panchayat is null)
        {
            throw new PanchayatNotFoundException(command.Id);
        }
        panchayat.Delete();
        await _repository.UpdateAsync(panchayat);
    }
}