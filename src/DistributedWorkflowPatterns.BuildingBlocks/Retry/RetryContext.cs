namespace DistributedWorkflowPatterns.BuildingBlocks.Retry;

public sealed class RetryContext
{
    public int Attempt { get; init; }

    public Exception? LastException { get; init; }
}