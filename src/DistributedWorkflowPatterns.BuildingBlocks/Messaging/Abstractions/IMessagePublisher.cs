namespace DistributedWorkflowPatterns.BuildingBlocks.Messaging.Abstractions;

using DistributedWorkflowPatterns.BuildingBlocks.Messaging.Models;

public interface IMessagePublisher
{
    Task PublishAsync(
        Message message,
        CancellationToken cancellationToken = default);
}