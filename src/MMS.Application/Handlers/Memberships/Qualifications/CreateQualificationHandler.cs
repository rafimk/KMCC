using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Memberships.Qualifications;
using MMS.Domain.Entities.Memberships.Qualifications;
using MMS.Domain.Repositories.Memberships.Qualifications;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Memberships.Qualifications;

internal sealed class CreateQualificationHandler : ICommandHandler<CreateQualification>
{
    private readonly IQualificationRepository _repository;

    public CreateQualificationHandler(IQualificationRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateQualification command)
    {
        var qualification = new Qualification();
        qualification.Create(Guid.NewGuid(), command.Name, DateTime.UtcNow);
        await _repository.AddAsync(qualification);
    }
}