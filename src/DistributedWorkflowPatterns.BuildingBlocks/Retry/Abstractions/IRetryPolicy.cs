namespace DistributedWorkflowPatterns.BuildingBlocks.Retry.Abstractions;

public interface IRetryPolicy
{
    bool ShouldRetry(RetryContext context);

    TimeSpan GetDelay(RetryContext context);
}