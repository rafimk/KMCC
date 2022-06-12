using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Nationalities.Districts;
using MMS.Domain.Entities.Nationalities;
using MMS.Domain.Repositories.Nationalities;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Nationalities.Districts;

internal sealed class CreateDistrictHandler : ICommandHandler<CreateDistrict>
{
    private readonly IDistrictRepository _repository;

    public CreateDistrictHandler(IDistrictRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateDistrict command)
    {
        var district = new District();
        district.Create(Guid.NewGuid(), command.Name, DateTime.UtcNow);
        await _repository.AddAsync(district);
    }
}