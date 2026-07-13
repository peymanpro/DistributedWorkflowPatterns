using DistributedWorkflowPatterns.BuildingBlocks.Retry;
using DistributedWorkflowPatterns.BuildingBlocks.Retry.Abstractions;

namespace DistributedWorkflowPatterns.Application.Retry;

public sealed class FixedIntervalRetryPolicy : IRetryPolicy
{
    private const int MaxAttempts = 3;

    public bool ShouldRetry(RetryContext context)
    {
        return context.Attempt < MaxAttempts;
    }

    public TimeSpan GetDelay(RetryContext context)
    {
        return TimeSpan.FromSeconds(1);
    }
}