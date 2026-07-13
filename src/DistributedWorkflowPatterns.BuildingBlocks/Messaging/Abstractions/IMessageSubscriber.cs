namespace DistributedWorkflowPatterns.BuildingBlocks.Messaging.Abstractions;

using DistributedWorkflowPatterns.BuildingBlocks.Messaging.Models;

public interface IMessageSubscriber
{
    Task SubscribeAsync<TMessage>(
        Func<TMessage, CancellationToken, Task> handler,
        CancellationToken cancellationToken = default)
        where TMessage : Message;
}