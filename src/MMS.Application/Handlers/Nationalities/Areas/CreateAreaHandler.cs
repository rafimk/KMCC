using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Areas;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Areas;

internal sealed class CreateAreaHandler : ICommandHandler<CreateArea>
{
    private readonly IAreaRepository _repository;

    public CreateAreaHandler(IAreaRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateArea command)
    {
        var area = new Area();
        area.Create(Guid.NewGuid(), command.Name, command.StateId, command.Prefix, DateTime.UtcNow);
        await _repository.AddAsync(area);
    }
}
