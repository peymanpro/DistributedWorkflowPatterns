namespace DistributedWorkflowPatterns.BuildingBlocks.Saga.Choreography;

public interface ISagaEvent
{
    Guid CorrelationId { get; }

    DateTime OccurredAtUtc { get; }
}