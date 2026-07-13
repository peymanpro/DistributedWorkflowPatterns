namespace DistributedWorkflowPatterns.BuildingBlocks.Saga.Choreography;

public interface ISagaEventHandler<in TEvent>
    where TEvent : ISagaEvent
{
    Task HandleAsync(
        TEvent @event,
        CancellationToken cancellationToken = default);
}