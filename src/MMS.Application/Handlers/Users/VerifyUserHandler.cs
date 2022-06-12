using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Users;
using MMS.Application.Exceptions;
using MMS.Domain.Repositories.Users;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Users;

internal sealed class VerifyUserHandler : ICommandHandler<VerifyUser>
{
    private readonly IUserRepository _repository;

    public VerifyUserHandler(IUserRepository repository)
        => _repository = repository;

    public async Task HandleAsync(VerifyUser command)
    {
        var user = await _repository.GetByIdAsync(command.Id);

        if (user is null)
        {
            throw new UserNotFoundException(command.Id);
        }
        
        await _repository.Verify(command.Id, DateTime.UtcNow);
    }
}
