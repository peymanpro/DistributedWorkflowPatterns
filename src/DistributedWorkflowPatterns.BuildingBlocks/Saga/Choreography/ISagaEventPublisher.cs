namespace DistributedWorkflowPatterns.BuildingBlocks.Saga.Choreography;

public interface ISagaEventPublisher
{
    Task PublishAsync(
        ISagaEvent @event,
        CancellationToken cancellationToken = default);
}