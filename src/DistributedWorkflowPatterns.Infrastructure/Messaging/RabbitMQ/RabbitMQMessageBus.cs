using DistributedWorkflowPatterns.BuildingBlocks.Messaging.Abstractions;
using DistributedWorkflowPatterns.BuildingBlocks.Messaging.Models;

namespace DistributedWorkflowPatterns.Infrastructure.Messaging.RabbitMQ;

public sealed class RabbitMQMessageBus : IMessageBus
{
    public Task PublishAsync(
        Message message,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SubscribeAsync<TMessage>(
        Func<TMessage, CancellationToken, Task> handler,
        CancellationToken cancellationToken = default)
        where TMessage : Message
    {
        throw new NotImplementedException();
    }
}