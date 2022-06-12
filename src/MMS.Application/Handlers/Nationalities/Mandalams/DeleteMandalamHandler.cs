using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Mandalams;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Mandalams;

internal sealed class DeleteMandalamHandler : ICommandHandler<DeleteMandalam>
{
    private readonly IMandalamRepository _repository;

    public DeleteMandalamHandler(IMandalamRepository repository)
        => _repository = repository;

    public async Task HandleAsync(DeleteMandalam command)
    {
        var mandalam = await _repository.GetByIdAsync(command.Id);

        if (mandalam is null)
        {
            throw new MandalamNotFoundException(command.Id);
        }
        mandalam.Delete();
        await _repository.UpdateAsync(mandalam);
    }
}