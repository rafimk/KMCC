using System;
using System.Threading.Tasks;
using MMS.Application.Commands.Users;
using MMS.Domain.Contracts.Users;
using MMS.Domain.Entities.Users;
using MMS.Domain.Repositories.Users;
using MMS.Shared.Abstractions.Commands;

namespace MMS.Application.Handlers.Users;

internal sealed class CreateUserHandler : ICommandHandler<CreateUser>
{
    private readonly IUserRepository _repository;

    public CreateUserHandler(IUserRepository repository)
        => _repository = repository;

    public async Task HandleAsync(CreateUser command)
    {
        var user = new User();
        var contract = new UserCreateContract
        {
            Id = Guid.NewGuid(),
            FullName = command.FullName,
            Email = command.Email,
            MobileNumber = command.MobileNumber,
            AlternativeContactNumber = command.AlternativeContactNumber,
            PasswordHash = "Abc123",
            CreatedAt = DateTime.UtcNow,
        };
        user.Create(contract);
        await _repository.AddAsync(user);
    }
}