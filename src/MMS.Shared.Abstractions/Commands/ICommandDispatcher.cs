using System.Threading.Tasks;

namespace MMS.Shared.Abstractions.Commands;

public interface ICommandDispatcher
{
    Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, ICommand;
}
